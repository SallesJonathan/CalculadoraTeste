using Calculadora;

namespace CalculadoraTeste
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculator.Somar(10,10));
        }
    }
}