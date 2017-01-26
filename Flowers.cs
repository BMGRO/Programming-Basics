using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            // Providing all initially required parameters through the console //

            Console.Write("Please provide number of Chrysanthemums: ");
            var countChrysanthemum = double.Parse(Console.ReadLine());
            Console.Write("Please provide number of Roses: ");
            var countRoses = double.Parse(Console.ReadLine());
            Console.Write("Please provide number of Tulips: ");
            var countTulips = double.Parse(Console.ReadLine());
            Console.Write("Please provide the season type: ");
            var season = Console.ReadLine();
            Console.Write("Please provide the type of day: ");
            var day = Console.ReadLine();

            // Declaring the price variables //
            var priceChrysnthemum = 0.0;
            var priceRoses = 0.0;
            var priceTulips = 0.0;

            // Handling the price differences, depending on the type of season //

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceChrysnthemum = 2.00; priceRoses = 4.10; priceTulips = 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    priceChrysnthemum = 3.75; priceRoses = 4.50; priceTulips = 4.15;
                    break;
            }

            // Counting the total discount and then doing the addiotnal discount checks with nested if/else clauses //

            {
                var total = (priceChrysnthemum * countChrysanthemum) + (priceRoses * countRoses) + (priceTulips * countTulips);
                if (countRoses + countChrysanthemum + countTulips > 20)
                    total = total - (total * 20.0 / 100);
                else total = total + 0.00;
                {
                    if (day == "Y")
                        total = total + (total * 15.0 / 100);
                    else if (day == "N")
                        total = total + 0.0;
                    {
                        if (season == "Spring" && countTulips > 7)
                            total = total - (total * 5.0 / 100);
                        else
                            if (season == "Winter" && countRoses >= 10)
                            total = total - (total * 10.0 / 100);
                    }
                    Console.WriteLine("The total price is: {0:F2}", total + 2.0);
                }
            }
        }
    }
}