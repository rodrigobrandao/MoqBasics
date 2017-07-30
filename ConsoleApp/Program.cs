using MoqBasics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository();
            var controller = new MoqBasics.BandController(repository);
            var listOfBands = controller.GetBands();
        }
    }
}
