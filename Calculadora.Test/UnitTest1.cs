using NUnit.Framework;

namespace Calculadora.Test
{
    public class CalculadoraTest
    {
        [TestFixture]
        public class CalculadoraSimplesTest
        {
            [Test]
            public void SomarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Adicionar(5, 5);

                Assert.That(result, Is.EqualTo(10));
            }

            [Test]
            public void MultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Multiplicar(5, 3);

                Assert.That(result, Is.EqualTo(15));
            }
        }
    }
}