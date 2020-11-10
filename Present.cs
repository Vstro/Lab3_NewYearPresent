using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Present
    {
        public List<Candy> Candies { get; private set; } = new List<Candy>();

        public Present() { }
        public Present(params Candy[] candies)
        {
            Candies = candies.ToList();
        }

        public void AddCandy(Candy newCandy)
        {
            Candies.Add(newCandy);
        }

        public void AddCandy(Sweet filling, Sweet cover)
        {
            Candies.Add(new Candy(filling, cover));
        }

        public int GetWeght()
        {
            return Candies.Select(c => c.GetWeight()).Aggregate((w1, w2) => w1 + w2);
        }

        public List<Candy> SortByWeight()
        {
            Candies.Sort((c1, c2) => c1.GetWeight() - c2.GetWeight());
            return Candies;
        }

        public List<Candy> SortBySugarPercent()
        {
            Candies.Sort((c1, c2) => 
            {
                return c1.GetSugarPercent() - c2.GetSugarPercent();
            });
            return Candies;
        }

        public List<Candy> GetCandiesWithSugarPercent(double from, double to)
        {
            return Candies.FindAll(c => (c.GetSugarPercent() > from && c.GetSugarPercent() < to));
        }
    }
}
