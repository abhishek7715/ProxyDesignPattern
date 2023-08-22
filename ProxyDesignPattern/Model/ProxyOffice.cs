using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern.Model
{
    internal class ProxyOffice:IOffice
    {
        private RealOffice _realOffice;
        private string _authorizedEmployee = "John";
        public ProxyOffice()
        {
            _realOffice = new RealOffice();
        }
        public void Enter(string employeeName)
        {
            if (employeeName == _authorizedEmployee)
            {
                _realOffice.Enter(employeeName);
            }
            else
            {
                Console.WriteLine($"{employeeName} is not authorized to enter the office.");
            }
        }
    }
}
