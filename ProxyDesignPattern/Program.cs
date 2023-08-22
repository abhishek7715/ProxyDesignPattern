using ProxyDesignPattern.Model;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOffice office = new ProxyOffice();

            
            office.Enter("Alice");
            office.Enter("John");
        }
    }
}