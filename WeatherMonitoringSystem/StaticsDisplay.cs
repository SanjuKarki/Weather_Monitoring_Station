namespace WeatherApp
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private List<double> currenttemperatureData;

        public StatisticsDisplay()
        {
            currenttemperatureData = new List<double>();
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            currenttemperatureData.Add(temperature);
            Display();
        }

        public void Display()
        {
            if (currenttemperatureData.Any())
            {
                double maxTemperature = currenttemperatureData.Max();
                double minTemperature = currenttemperatureData.Min();
                double averageTemperature = currenttemperatureData.Average();

                Console.WriteLine("Temperature Statistics:");
                Console.WriteLine($"Max Temperature: {maxTemperature}");
                Console.WriteLine($"Min Temperature: {minTemperature}");
                Console.WriteLine($"Average Temperature: {averageTemperature}");
            }
            else
            {
                Console.WriteLine("No temperature data available.");
            }
        }
    }
}
