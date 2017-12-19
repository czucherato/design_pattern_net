using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaVeiculo fabrica = new FabricaVeiculoConcreta();

            IFabrica scooter = fabrica.ObterVeiculo("Scooter");
            scooter.Dirigir(10);

            IFabrica bike = fabrica.ObterVeiculo("Bike");
            bike.Dirigir(20);

            Console.ReadKey();
        }
    }
}
