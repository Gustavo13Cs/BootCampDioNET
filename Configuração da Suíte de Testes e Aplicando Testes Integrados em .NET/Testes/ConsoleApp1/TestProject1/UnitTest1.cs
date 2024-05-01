using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int val1,int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalculadora = calc.somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalculadora = calc.multi(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 2, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalculadora = calc.divi(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSub(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();


            int resultadoCalculadora = calc.sub(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc= new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.divi(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(1, 2);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}