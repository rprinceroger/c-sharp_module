using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    // Abstraction
    // Hides complex implementation details, showing only essential features (function).
    // Can be achieved using iterfaces

    internal interface ICalculator
    // Interfaces define a contract (serves a blueprint) of methods that must be implemented by derived class/es
    {
        void Compute(double numA, double numB, String operation);
        void TurnOff();












    }
}
