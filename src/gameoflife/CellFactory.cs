using System;
using System.Collections.Generic;

namespace gameoflife
{
    public class CellFactory : ICreateCells
    {
        public IEnumerable<IAmACell> create_cell_grid_of_size(int size)
        {
            throw new NotImplementedException(); 
        }
    }
}