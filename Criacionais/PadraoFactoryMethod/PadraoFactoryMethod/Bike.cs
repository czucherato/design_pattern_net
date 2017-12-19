using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public class Bike : IFabrica
    {
        public void Dirigir(int milhas)
        {
            Console.WriteLine("Dirigir uma Bike: " + milhas.ToString() + "km");
        }
    }
}
