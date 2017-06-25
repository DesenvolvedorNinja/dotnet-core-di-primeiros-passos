using System;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDI
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection collection = new ServiceCollection();
            collection.AddTransient<ICalculo, Soma>();
            collection.AddTransient<ICalculo, Subtracao>();
            collection.AddSingleton<Calculadora>();
            IServiceProvider serviceProvider = collection.BuildServiceProvider();

            Calculadora calculadora = serviceProvider.GetService<Calculadora>();

            calculadora.EfetuarCalculo(10, 20);
            Console.Read();
        }
    }
}