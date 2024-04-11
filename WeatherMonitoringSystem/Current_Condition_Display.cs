

namespace WeatherApp
{

    /// <summary>
    /// Manages the display of current weather conditions.  
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        // Variables to store current weather data.
        private double currentTemperature; 
        private double currentHumidity; 
        private double currentpressure; 

        //Updates weather data display
        //<param name="temperature">The updated temperature value in Celsius.</param>
        //<param name="humidity">The updated humidity value as a percentage.</param>
        // <param name="pressure">The updated pressure value in hectopascals (hPa).</param>
        public void Update(double temperature, double humidity, double pressure)
        {
            this.currentTemperature = temperature;
            this.currentHumidity = humidity;
            this.currentpressure = pressure;
            Display();
        }

       /// <summary>
       /// Displays the current weather conditions.
       /// </summary>
        public void Display()
        {
            Console.WriteLine($"Weather Display:");
            Console.WriteLine($"Temperature: {currentTemperature}°C");
            Console.WriteLine($"Humidity: {currentHumidity}%");
            Console.WriteLine($"Pressure: {currentpressure} hPa"); // Added pressure display.
        }
    }
}