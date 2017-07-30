using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasics
{
    public interface IRepository
    {
        List<Band> GetBands();
    }
}
