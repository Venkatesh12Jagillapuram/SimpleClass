using System.Reflection.Metadata.Ecma335;

namespace SimpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {        
             Car myCar = new Car();
            myCar.Make = "BENZ";
            myCar.Model = "S-Class";
            myCar.year = 2021;
            myCar.Color = "White";
            myCar.Price = 8000;

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", 
                myCar.Make,
                myCar.Model, 
                myCar.year,
                myCar.Color, 
                myCar.Price);

            //decimal value = determineMarketValue(myCar);
            //  Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}",myCar.DetermineMarketVale());
            Console.ReadLine();
        }

        private static decimal determineMarketValue(Car car )
        {
            decimal carprice = 120.0M;

            //Someday I Might Look up the Car
            // online webservices to get more
            // accurate value.
            return carprice;
        }
    }

     class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public string Color { get; set; }
        public decimal  Price { get; set; }

        public decimal DetermineMarketVale()
        {
            decimal carValue;

            if (year < 2021)
                carValue = 50000;
            else
                carValue = 8000;

            return carValue;

        }
    }


}
