
namespace WeatherApp
{

    /// <summary>
    /// Represents weather data and manages observer subscriptions.
    /// </summary>
    public class WeatherData : ISubject
    {
        // Singleton instance of WeatherData.
        private static WeatherData? instance; 


        private double temp; // Current temperature.
        private double humidity; // current humidity.
        private double pressure; // current pressure
        private readonly List<IObserver> observers; // List of observers subscribed to weather updates.

        /// <summary>
        /// Private constructor to prevent external instantiation.
        /// </summary>
        private WeatherData()
        {
            observers = [];
        }

        /// <summary>
        /// Gets the singleton instance of WeatherData.
        /// </summary>
        /// <returns>The singleton instance of WeatherData.</returns>
        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        /// <summary>
        /// Sets the current weather measurements and notifies observers.
        /// </summary>
        /// <param name="temperature">The new temperature value.</param>
        /// <param name="humidity">The new humidity value.</param>
        /// <param name="pressure">The new pressure value.</param>

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temp = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        /// <summary>
        /// Registers an observer to receive weather updates.
        /// </summary>
        /// <param name="observer">The observer to register.</param>
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from receiving weather updates.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all observers with the current weather data.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }
    }
}