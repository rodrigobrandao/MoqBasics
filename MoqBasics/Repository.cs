using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqBasics
{
    public class Repository: IRepository 
    {
        public Repository()
        {

        }

        public List<Band> GetBands()
        {
            var listOfBands = new List<Band>();

            listOfBands.Add(new Band { Name = "Bayside", Origin="Queens, New York, USA", Genre = "Alternative", BestSong="I And I"});
            listOfBands.Add(new Band { Name = "Brand New", Origin = "Long Island, New York, USA", Genre = "Alternative", BestSong = "The Quiet Things That No One Ever Knows" });

            return listOfBands;
        }

    }
}
