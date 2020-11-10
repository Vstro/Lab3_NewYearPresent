using System;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            Present present = new Present();

            Console.Write("The present has:\n" + present.WhatsInPresent());
            Console.WriteLine("The present's weight is " + present.GetTotalWeight() + "g");
            Console.WriteLine("The present's sugar percent is " + present.GetSugarPercent() + "%");
            Console.WriteLine();

            present.Candies.Add(new Candy(new Souffle(), new Chocolate(SweetSize.Big)));
            present.Candies.Add(new Candy(new Nougat(), new Caramel()));
            present.Candies.Add(new Candy(new Nuts(20), new WhiteChocolate(SweetSize.Small)));
            present.Candies.Add(new Candy(new Nougat(), new Chocolate()));
            present.Candies.Add(new Candy(new Chocolate(), new Caramel()));

            Console.Write("Now, the present has:\n" + present.WhatsInPresent());
            Console.WriteLine("The present's weight is " + present.GetTotalWeight() + "g");
            Console.WriteLine("The present's sugar percent is " + present.GetSugarPercent() + "%");
            Console.WriteLine();

            present.SortBySugarPercent();

            Console.Write("The sorted by sugar percent present has:\n" + present.WhatsInPresent());
            Console.WriteLine("The present's weight is " + present.GetTotalWeight() + "g");
            Console.WriteLine("The present's sugar percent is " + present.GetSugarPercent() + "%");
            Console.WriteLine();

            present.SortByWeight();

            Console.Write("The sorted by weight present has:\n" + present.WhatsInPresent());
            Console.WriteLine("The present's weight is " + present.GetTotalWeight() + "g");
            Console.WriteLine("The present's sugar percent is " + present.GetSugarPercent() + "%");
            Console.WriteLine();

            double lowerBound, upperBound;
            Console.Write("Input lower bound for sugar percent search in the present: ");
            while (!double.TryParse(Console.ReadLine(), out lowerBound)) ;
            Console.Write("Input upper bound for sugar percent search in the present: ");
            while (!double.TryParse(Console.ReadLine(), out upperBound)) ;

            Console.WriteLine("Candies with such sugar percent:");
            foreach (Candy c in present.GetCandiesWithSugarPercent(lowerBound, upperBound))
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
