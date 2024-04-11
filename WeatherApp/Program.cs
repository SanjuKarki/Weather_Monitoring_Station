namespace WeatherApp
{

    /// <summary>
    /// Represents the main entry point for the weather monitoring application.
    /// </summary>
    class Program
    {

        /// <summary>
        /// The main method of the program that initializes the weather station, creates displays,
        /// registers observers, and updates weather data.
        /// </summary>
        /// <param name="args">Optional command-line arguments.</param>
        static void Main(string[] args)
        {
          // Initialize the weather station and get the weather data singleton instance.           
            WeatherStation station = new WeatherStation();
            WeatherData weatherData = WeatherData.GetInstance();

         // Create display objects for current conditions, statistics, and forecast.
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();

          // Register the display objects as observers with the weather data singleton.
            weatherData.RegisterObserver(currentDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);

            // Simulate weather data updates with random values.
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                double temperature = random.Next(50, 100);
                double humidity = random.Next(0, 100);
                double pressure = random.Next(20, 40);

                // Set new weather measurements to trigger observer updates.
                weatherData.SetMeasurements(temperature, humidity, pressure);
            }
        }
    }
}