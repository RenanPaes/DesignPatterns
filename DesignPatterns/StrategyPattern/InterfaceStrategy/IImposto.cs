using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.InterfaceStrategy
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
