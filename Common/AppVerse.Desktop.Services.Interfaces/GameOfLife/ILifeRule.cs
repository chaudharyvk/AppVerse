﻿using AppVerse.Desktop.Models.GameOfLife;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVerse.Desktop.Services.Interfaces.GameOfLife
{
    public interface ILifeRule
    {
        CellState EvaluateCell(Cell cell);
    }
}