

namespace WeatherApp
{
    
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private double currentTemperature; 
        private double currentHumidity; 
        private double currentpressure; 

        public void Update(double temperature, double humidity, double pressure)
        {
            this.currentTemperature = temperature;
            this.currentHumidity = humidity;
            this.currentpressure = pressure;
            Display();
        }


        public void Display()
        {
            Console.WriteLine($"Weather Display:");
            Console.WriteLine($"Temperature: {currentTemperature}°C");
            Console.WriteLine($"Humidity: {currentHumidity}%");
        }
    }
}