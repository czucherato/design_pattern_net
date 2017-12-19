using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public class Scooter : IFabrica
    {
        public void Dirigir(int milhas)
        {
            Console.WriteLine("Dirija a Scooter: " + milhas.ToString() + "km");
        }
    }
}
