using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature in F");

            input = Console.ReadLine();

            temperature = int.Parse(input);
            if (temperature > 50)
            {
                Console.WriteLine("Enter Relative Humidity");
                int rh;
                input = Console.ReadLine();
                rh = int.Parse(input);
                double heatIndex;
                heatIndex = .5 * ((temperature + 61.0 + (temperature - 68.0) * 1.2) + (rh * .094));
                Console.WriteLine("The Heat Index is" + heatIndex);
            }
            else // Get the windspeed from user
            {
                Console.WriteLine("Enter the Wind Speed");
                input = Console.ReadLine();
                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
        }
    }
}
