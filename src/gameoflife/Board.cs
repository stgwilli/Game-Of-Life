using System.Collections.Generic;

namespace gameoflife
{
    public class Board : IAmTheBoard
    {
        readonly ICreateCells cell_factory;
        public IEnumerable<IAmACell> cells;

        public Board(ICreateCells cell_factory)
        {
            this.cell_factory = cell_factory;
        }

        public void initialize_to_size(int size)
        {
            cells = cell_factory.create_cell_grid_of_size(size);            
        }
    }
}