namespace WeatherApp
{

    public class WeatherStation
    {
        public IDisplay newDisplay(string display)
        {
            switch (display)
            {
                case "1":
                    return new CurrentConditionsDisplay();
                case "2":
                    return new StatisticsDisplay();
                case "3":
                    return new ForecastDisplay();
                default:
                    throw new ArgumentException("Invalid display type");
            }
        }
    }
}