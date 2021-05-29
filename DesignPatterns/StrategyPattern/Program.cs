using StrategyPattern.ConcreteStrategy;
using StrategyPattern.ContextStrategy;
using StrategyPattern.InterfaceStrategy;
using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var iss = new ISS();
            var icms = new ICMS();

            var orcamento = new Orcamento(500.0);

            var calculadora = new CalculadorImposto();

            calculadora.RealizaCalculo(orcamento, iss);
            calculadora.RealizaCalculo(orcamento, icms);

            Console.ReadKey();
        }
    }
}
