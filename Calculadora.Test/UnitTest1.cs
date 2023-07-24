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

                var result = sut.Somar(5, 5);

                Assert.That(result, Is.EqualTo(10));
            }

            [Test]
            public void SubtrairDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Subtrair(5, 3);

                Assert.That(result, Is.EqualTo(2));
            }

            [Test]
            public void MultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Multiplicar(5, 3);

                Assert.That(result, Is.EqualTo(15));
            }

            [Test]
            public void DividirDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Dividir(6, 2);

                Assert.That(result, Is.EqualTo(3));
            }
        }
    }
}