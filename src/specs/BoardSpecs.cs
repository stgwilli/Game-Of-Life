using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;
using gameoflife;

namespace specs
{
    public class BoardSpecs 
    {
        public abstract class concern : Observes<IAmTheBoard, Board>
        {
            
        }

        public class when_initializing_a_new_board : concern
        {
            Establish context = () =>
                {
                    the_size_of_the_grid = 4;
                    cell_factory = depends.on<ICreateCells>();
                };

            Because b = () => sut.initialize_to_size(the_size_of_the_grid);

            It should_ask_the_cell_factory_to_create_the_list_of_size =
                () => cell_factory.received(x => x.create_cell_grid_of_size(the_size_of_the_grid));

            static ICreateCells cell_factory;
            static int the_size_of_the_grid;
        }
    }
}
