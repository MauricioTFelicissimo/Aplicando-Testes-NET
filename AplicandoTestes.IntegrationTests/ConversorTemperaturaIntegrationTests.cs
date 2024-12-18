using NUnit.Framework;
using AplicandoTestes.Core;

namespace AplicandoTestes.IntegrationTests
{
    public class ConversorTemperaturaIntegrationTests
    {
        [TestCase(47, 8.33)]
        [TestCase(86, 30)]
        public void TestarConversaoTemperatura(double f, double esperado)
        {
            double resultado = ConversorTemperatura.FahrenheitParaCelsius(f);

            // Corrigir para usar Assert.That
            Assert.That(resultado, Is.EqualTo(esperado).Within(0.01));
        }
    }
}
