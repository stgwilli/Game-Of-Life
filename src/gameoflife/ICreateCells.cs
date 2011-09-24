using System.Collections.Generic;

namespace gameoflife
{
    public interface ICreateCells
    {
        IEnumerable<IAmACell> create_cell_grid_of_size(int size); 
    }
}