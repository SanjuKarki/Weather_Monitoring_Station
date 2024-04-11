namespace WeatherApp
{

    /// <summary>
    /// Represents a weather station that creates new display objects based on input.
    /// </summary>
    public class WeatherStation
        
        /// <summary>
        /// Creates a new display object based on the specified display type.
        /// </summary>
        /// <param name="display">The display type (1 for CurrentConditions, 2 for Statistics, 3 for Forecast).</param>
        /// <returns>A new display object of the specified type.</returns>
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