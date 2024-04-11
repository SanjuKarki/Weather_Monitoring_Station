namespace WeatherApp
{

    class Program
    {

        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            WeatherData weatherData = WeatherData.GetInstance();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();

            weatherData.RegisterObserver(currentDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);


            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                double temperature = random.Next(50, 100);
                double humidity = random.Next(0, 100);
                double pressure = random.Next(20, 40);

                weatherData.SetMeasurements(temperature, humidity, pressure);
            }
        }
    }
}