using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Snek.Shared.Board;


namespace Snek.Shared.Helpers
{
    public static class PanelExtensions
    {
        public static Panel At(this List<Panel> panels, int row, int column) =>
    panels.Where(x => x.pos.Row == row && x.pos.Column == column).First();

        public static List<Panel> Range(this List<Panel> panels, int startRow, int startColumn, int endRow, int endColumn)
        {
            return panels.Where(x => x.pos.Row >= startRow
                && x.pos.Column >= startColumn
                && x.pos.Row <= endRow
                && x.pos.Column <= endColumn).ToList();
        }
    }
}
