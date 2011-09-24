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
    public class CellFactorySpecs
    {
        public abstract class concern : Observes<ICreateCells, CellFactory>
        {
        
        }

        public class when_creating_the_cell_grid : concern
        {
            Establish context = () =>
                {
            
                };

            Because b = () =>
                {
        
                };

        
            It should_first_observation = () =>
                {
                    
                };
        }
    }
}
