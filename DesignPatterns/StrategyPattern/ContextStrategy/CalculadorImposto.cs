using StrategyPattern.InterfaceStrategy;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ContextStrategy
{
    public class CalculadorImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
