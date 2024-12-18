using Xunit;
using AplicandoTestes.Core;

namespace AplicandoTestes.UnitTests
{
    public class ConversorTemperaturaTests
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        public void FahrenheitParaCelsius_DeveRetornarResultadoCorreto(double f, double esperado)
        {
            double resultado = ConversorTemperatura.FahrenheitParaCelsius(f);
            Assert.Equal(esperado, resultado);
        }
    }
}
