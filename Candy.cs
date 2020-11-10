using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearPresent
{
    class Candy
    {
        public Sweet Filling { get; private set; }
        public Sweet Cover { get; private set; }

        public Candy(Sweet filling, Sweet cover)
        {
            Filling = filling;
            Cover = cover;
        }
    
        public int GetWeight()
        {
            return Filling.Weight + Cover.Weight;
        }

        public double GetSugarPercent()
        {
            return (Filling.Weight * Filling.SugarPercent + Cover.Weight * Cover.SugarPercent) / GetWeight();
        }
    }
}
