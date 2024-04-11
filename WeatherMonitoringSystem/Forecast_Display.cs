
namespace WeatherApp
{
    /// Manages the display of weather forecasts based on current weather conditions.
    public class ForecastDisplay : IObserver, IDisplay
    {
        // Stores the current weather forecast
        private string? currentForecast;

        /// <summary>
        /// Updates the forecast based on the given weather parameters.
        /// </summary>
        /// <param name="temperature">The current temperature in Celsius.</param>
        /// <param name="humidity">The current humidity level as a percentage.</param>
        /// <param name="pressure">The current atmospheric pressure in hPa (hectopascals).</param>
        public void Update(double temperature, double humidity, double pressure)
        {

            currentForecast = CalculateForecast(temperature, humidity, pressure);
            Display();
        }

        /// Displays the current weather forecast.
        public void Display()
        {
            Console.WriteLine($"Weather Forecast: {currentForecast}");
        }

         // Calculates the weather forecast based on temperature, humidity, and pressure.
        private string CalculateForecast(double temperature, double humidity, double pressure)
        {

            if (temperature > 25 && humidity < 70)
            {
                return "Sunny";
            }
            else if (temperature <= 25 && humidity > 70)
            {
                return "Rainy";
            }
            else
            {
                return "Partly Cloudy";
            }
        }
    }
}
