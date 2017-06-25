using System;
using System.Collections.Generic;

namespace DemoDI
{
    public class Calculadora
    {
        private readonly IEnumerable<ICalculo> calculos;

        public Calculadora(IEnumerable<ICalculo> calculos)
        {
            this.calculos = calculos;
        }

        public void EfetuarCalculo(double a, double b)
        {
            foreach (var calculo in calculos)
            {
                var result = calculo.Calcular(a, b);
                Console.WriteLine($"Resultado: {result}");
            }
        }
    }
}