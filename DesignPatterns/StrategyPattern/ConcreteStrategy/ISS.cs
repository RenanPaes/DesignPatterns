using StrategyPattern.InterfaceStrategy;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteStrategy
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06;
    }
}
