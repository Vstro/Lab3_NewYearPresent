using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearPresent
{
    class Present
    {
        public List<Candy> Candies { get; set; } = new List<Candy>();

        public Present() { }

        public Present(params Candy[] candies)
        {
            Candies = candies.ToList();
        }

        public int GetTotalWeight()
        {
            if (Candies.Count == 0) return 0;
            return Candies.Select(c => c.GetWeight()).Aggregate((w1, w2) => w1 + w2);
        }

        public double GetSugarPercent()
        {
            if (Candies.Count == 0) return 0;
            double totalSugar = 0;
            foreach (Candy c in Candies)
            {
                totalSugar += c.GetSugarPercent() * c.GetWeight();
            }
            return totalSugar / GetTotalWeight();
        }

        public List<Candy> SortByWeight(bool ascending = true)
        {
            if (ascending)
            {
                Candies.Sort((c1, c2) => c1.GetWeight() - c2.GetWeight());
            }
            else
            {
                Candies.Sort((c1, c2) => c2.GetWeight() - c1.GetWeight());
            }
            return Candies;
        }

        public List<Candy> SortBySugarPercent(bool ascending = true)
        {
            Candies.Sort((c1, c2) =>
            {
                if (c1.GetSugarPercent() < c2.GetSugarPercent())
                {
                    if (ascending) return -1;
                    return 1;
                }
                if (c1.GetSugarPercent() > c2.GetSugarPercent())
                {
                    if (ascending) return 1;
                    return -1;
                }
                return 0;
            });
            return Candies;
        }

        public List<Candy> GetCandiesWithSugarPercent(double lowerBound, double? upperBound = null)
        {
            if (!upperBound.HasValue || lowerBound.Equals(upperBound))
            {
                return Candies.FindAll(c => c.GetSugarPercent().Equals(lowerBound));
            }
            return Candies.FindAll(c => (c.GetSugarPercent() >= lowerBound && c.GetSugarPercent() <= upperBound));
        }

        public String WhatsInPresent()
        {
            if (Candies.Count == 0) return "Nothing\n";
            StringBuilder result = new StringBuilder();
            foreach (Candy c in Candies)
            {
                result.Append(c.ToString() + "\n");
            }
            return result.ToString();
        }
    }
}
