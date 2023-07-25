using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public interface ICalculadoraBasica
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        double Dividir(int num1, int num2);
    }

    public interface ICalculadoraAvancada
    {
        double RaizQuadrada(double number);
        double Potencia(double baseNumber, int exponent);
    }
    public class CalculadoraSimples : ICalculadoraBasica, ICalculadoraAvancada
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Não é possível dividir por zero.");
            }
            return num1 / num2;
        }

        public double RaizQuadrada(double number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            return Math.Sqrt(number);
        }

        public double Potencia(double baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }

    }
}
