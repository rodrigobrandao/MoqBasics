using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasics
{
    public class BandController
    {
        IRepository Repository;
                
        public BandController(IRepository repository)
        {
            this.Repository = repository;
        }

        public List<Band> GetBands()
        {
            return this.Repository.GetBands();
        }
    }
}
