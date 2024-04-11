
namespace WeatherApp
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private string? currentForecast;

        public void Update(double temperature, double humidity, double pressure)
        {

            currentForecast = CalculateForecast(temperature, humidity, pressure);
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Weather Forecast: {currentForecast}");
        }

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
