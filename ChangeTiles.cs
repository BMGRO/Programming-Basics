using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            // Collecting input for all initial parameters needed for the program //

            Console.Write("Please provide the amount of collected money: ");
            var collectedMoney = double.Parse(Console.ReadLine());
            Console.Write("Please provide the floor width: ");
            var widthFloor = double.Parse(Console.ReadLine());
            Console.Write("Please provide the floor length: ");
            var lengthFloor = double.Parse(Console.ReadLine());
            Console.Write("Please provide the triangle side: ");
            var triangleSide = double.Parse(Console.ReadLine());
            Console.Write("Please provide the triangle height: ");
            var triangleHeight = double.Parse(Console.ReadLine());
            Console.Write("Please provide the tile price per unit: ");
            var priceTile = double.Parse(Console.ReadLine());
            Console.Write("Please provide the price for the worker: ");
            var priceWorker = double.Parse(Console.ReadLine());

            // Defining calculation variables //

            var floorArea = widthFloor * lengthFloor;
            var areaTile = triangleSide * triangleHeight / 2;
            var neededTiles = Math.Ceiling(floorArea / areaTile) + 5;
            var totalSum = (neededTiles * priceTile) + priceWorker;

            // Handling the conditions needed for the left over money calculations //

            if (totalSum <= collectedMoney)
            {
                Console.WriteLine("{0:F2} lv left.", collectedMoney - totalSum);
            }
            else
                if (totalSum > collectedMoney)
            {
                Console.WriteLine("You'll need {0:F2} lv more.", totalSum - collectedMoney);
            }
        }
    }
}
