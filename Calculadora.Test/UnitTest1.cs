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

            [Test]
            public void RaizQuadradaDeUmNumero()
            {
                var sut = new CalculadoraSimples();

                var result = sut.RaizQuadrada(4);

                Assert.That(result, Is.EqualTo(2));
            }

            [Test]
            public void PotenciaDoisNumeros()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Potencia(4,2);

                Assert.That(result, Is.EqualTo(16));
            }

            [Test]
            public void PotenciaComZero()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Potencia(5, 0);

                Assert.That(result, Is.EqualTo(1));
            }

            [Test]
            public void PotenciaComNumeroNegativo()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Potencia(2, -2);

                Assert.That(result, Is.EqualTo(0.25));
            }

            [Test]
            public void PotenciaComBaseZero()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Potencia(0, 10);

                Assert.That(result, Is.EqualTo(0));
            }
            [Test]
            public void PotenciaComBaseUm()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Potencia(1, 100);

                Assert.That(result, Is.EqualTo(1));
            }
            [Test]
            public void PotenciaComExpoenteUm()
            {
                var sut = new CalculadoraSimples();

                var result = sut.Potencia(5, 1);

                Assert.That(result, Is.EqualTo(5));
            }

            [Test]
            public void RaizQuadradaDeNumeroNegativo()
            {
                var sut = new CalculadoraSimples();

                Assert.Throws<ArgumentException>(() => sut.RaizQuadrada(-4));
            }

            [Test]
            public void TestDividirPorZero()
            {
                // Arrange
                var sut = new CalculadoraSimples();

                // Act & Assert
                Assert.Throws<ArgumentException>(() => sut.Dividir(8, 0)); // Não é possível dividir por zero
            }
        }
    }
}