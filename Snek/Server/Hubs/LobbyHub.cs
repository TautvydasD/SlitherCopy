using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;
using Snek.Server.Entities;

namespace Snek.Server.Hubs
{
    
    public class LobbyHub : Hub
    {
        static ConcurrentDictionary<string, string> playerList = new ConcurrentDictionary<string, string>();
        public LobbyHub()
        {
           
        }
        
        public override async Task OnConnectedAsync()
        {
            Console.WriteLine("Client Connected: " + this.Context.ConnectionId);
            //var otherNames = new List<string>();
            string otherName = null;
            Console.WriteLine("Players Count : " + playerList.Count);

            if(playerList.Count > 0 && playerList.Count < 4)
            {
                await Clients.Others.SendAsync("SendUserInformation", this.Context.ConnectionId);
            }
            else if (playerList.Count == 0)
            {

                await Clients.Caller.SendAsync("GetConnectionId", this.Context.ConnectionId, otherName);

                
               
            }
            else if (playerList.Count > 3)
            {
                await Clients.Caller.SendAsync("NoRoom");
            }
        }

        public async Task SendUserInformation(string otherUserName, string senderConnectionID)
        {
            await Clients.Client(senderConnectionID).SendAsync("GetUserInformation", otherUserName, senderConnectionID);
        }

        public async Task AddList(string userName, string connectionID)
        {
            if(playerList.Count > 0 && playerList.Count < 4)
            {
                playerList.TryAdd(userName, connectionID);
            }
            else if(playerList.Count == 0)
            {
                playerList.TryAdd(userName, connectionID);
                await Clients.All.SendAsync("ReceiveUser", userName, connectionID);
            }
        }

        public async Task LoginUser(string userName, string connectionID)
        {
            await AddList(userName, connectionID);
        }

        public override async Task OnDisconnectedAsync(Exception exception) // dont understand this method, left everything the same as the original
        {
            Console.WriteLine("Player Disconnected:" + Context.ConnectionId);
            if (playerList.Count > 0)
            {
                string connectionId = Context.ConnectionId;
                Console.WriteLine("Client If Disconnected:" + connectionId);
                string userName = playerList.FirstOrDefault(entry => entry.Value == connectionId).Key;
                Console.WriteLine("Client If Disconnected UserName:" + userName);
                if (userName != null)
                {
                    playerList.TryRemove(userName, out _);
                }
                if (playerList.Count == 1 || playerList.Count == 0)
                {
                    await Clients.Others.SendAsync("RemoveUser", userName, connectionId);
                }
            }
            await base.OnDisconnectedAsync(exception);
        }
    }
}
