namespace MyConsoleApp
{
    class Program
    {
        static double baseValue = 0;
        static double finalValue = 0;
        static int twoHundred;
        static int oneThousand;

        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            baseValue = distance * 0.1;
            calculateFreight(distance, weight);

        }

        static void calculateFreight(double distance, double weight)
        {
            if (distance > 200)
            {
                twoHundred = (int)(distance / 200);
                finalValue += twoHundred * 1;
            }
            if (distance > 1000)
            {
                oneThousand = (int)(distance / 1000);
                finalValue += oneThousand * 10;
            }

            finalValue += baseValue;

            if (weight < 5)
            {
                Console.WriteLine("No additional fare");
            }
            if (weight >= 5 && weight <= 25)
            {
                finalValue = finalValue * 5;
            }
            if (weight >= 25 && weight <= 75)
            {
                finalValue = finalValue * 3;
            }

            Console.WriteLine(finalValue);

        }

    }

}
