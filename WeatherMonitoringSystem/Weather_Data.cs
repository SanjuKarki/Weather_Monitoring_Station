

namespace WeatherApp
{

    public class WeatherData : ISubject
    {
        private static WeatherData? instance; 
        private double temp; 
        private double humidity; 
        private double pressure; 
        private readonly List<IObserver> observers; 

        private WeatherData()
        {
            observers = [];
        }

        public static WeatherData GetInstance()
        {
            if (instance == null)
            {
                instance = new WeatherData();
            }
            return instance;
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            this.temp = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }
    }
}