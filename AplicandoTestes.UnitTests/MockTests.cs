using Moq;
using Xunit;
using FluentAssertions;

namespace AplicandoTestes.UnitTests
{
    public interface IConversor
    {
        double Converter(double tempF);
    }

    public class MockTests
    {
        [Fact]
        public void Conversor_DeveRetornarValorEsperado()
        {
            var mock = new Mock<IConversor>();
            mock.Setup(m => m.Converter(32)).Returns(0);

            var resultado = mock.Object.Converter(32);

            resultado.Should().Be(0, "a conversão de 32°F para Celsius deve ser 0");
        }
    }
}
