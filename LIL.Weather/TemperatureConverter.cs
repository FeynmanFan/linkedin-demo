namespace LIL.Weather
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double temperature)
        {
            return temperature * 8 / 5 + 32;
        }
    }
}