using System;

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
            return (Filling.Weight * Filling.SugarPercent + Cover.Weight * Cover.SugarPercent) / GetWeight() * 100;
        }

        public override String ToString()
        {
            return $"Candy with {Filling.Name} in {Cover.Name} (sugar percent: {GetSugarPercent()}%, weight: {GetWeight()}g)";
        }
    }
}
