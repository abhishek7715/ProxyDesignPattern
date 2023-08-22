using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Model
{
    internal class RealOffice:IOffice
    {
        public void Enter(string employeeName)
        {
            Console.WriteLine($"{employeeName} enters the office.");
        }
    }
}
