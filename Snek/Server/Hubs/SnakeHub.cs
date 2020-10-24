using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Snek.Shared.Classes;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;

namespace Snek.Server.Hubs
{
    public class SnakeHub : Hub
    {
        private IMemoryCache _cache;
        public SnakeHub(IMemoryCache cache)
        {
            _cache = cache;
            if (!_cache.TryGetValue("GameCacheKey", out List<Games> games))
            {
                _cache.Set("GameCacheKey", new List<Games>());
            }
        }

        public async Task SendMessage(string gameId, string playerId, string message)
        {
            var games = _cache.Get<List<Games>>("GameCacheKey");
            var game = games.FirstOrDefault(_ => _.Id == gameId);
            if (game != null)
            {
                if (!string.IsNullOrEmpty(game.Player1.ConnectionId))
                {
                    await Clients.Client(game.Player1.ConnectionId).SendAsync("GameMessage", game.GetPlayer(playerId).Username, message);
                }
                if (!string.IsNullOrEmpty(game.Player2.ConnectionId))
                {
                    await Clients.Client(game.Player2.ConnectionId).SendAsync("GameMessage", game.GetPlayer(playerId).Username, message);
                }
            }
        }

        public async Task InitGame(string user) //TODO: Get unique connection
        {
            Console.WriteLine(user);
            var game = GetSinglePlayerGame();
            if (game == null)
            {
                game = new Games(false);
                game.AddPlayer(user);
                var games = _cache.Get<List<Games>>("GameCacheKey");
                games.Add(game);
                game.Player1.ConnectionId = Context.ConnectionId;
                _cache.Set("GameCacheKey", games);
            }
            else
            {
                game.AddPlayer(user, false);
                game.Player2.ConnectionId = Context.ConnectionId;
                game.Start();
            }
            await SendUpdateGame(game);

        }

        private Games GetSinglePlayerGame() => _cache.Get<List<Games>>("GameCacheKey").FirstOrDefault(_ => _.SpotAvailable);

        private async Task SendUpdateGame(Games game)
        {
            if (!string.IsNullOrEmpty(game.Player1.ConnectionId))
            {
                await Clients.Client(game.Player1.ConnectionId).SendAsync("GameUpdated", game.Id);
            }
            if (!string.IsNullOrEmpty(game.Player2?.ConnectionId))
            {
                await Clients.Client(game.Player2.ConnectionId).SendAsync("GameUpdated", game.Id);
            }
        }
    }
}
