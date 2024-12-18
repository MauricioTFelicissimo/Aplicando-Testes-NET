namespace AplicandoTestes.Core;

public class ConversorTemperatura
{
    public static double FahrenheitParaCelsius(double tempF)
        => (tempF - 32) / 1.8;
}
