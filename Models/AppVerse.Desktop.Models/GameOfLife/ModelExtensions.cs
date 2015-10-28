﻿using System.Collections.Generic;
using System.Linq;

namespace AppVerse.Desktop.Models.GameOfLife
{
    public static class ModelExtensions
    {

        public static IEnumerable<Cell> CellsInBoard(this IEnumerable<CellRow> cellRow)
        {
            return cellRow.SelectMany(cellRowItem => cellRowItem.Select(cellItem => cellItem));
        }

        public static IEnumerable<Cell> CellsInBoard(this Board board)
        {
            return board.Cells.SelectMany(cellRowItem => cellRowItem.Select(cellItem => cellItem));
        }
    }
}
