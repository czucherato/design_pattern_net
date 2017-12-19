using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public class FabricaVeiculoConcreta : FabricaVeiculo
    {
        public override IFabrica ObterVeiculo(string veiculo)
        {
            switch (veiculo)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("O veículo '{0}' não pode ser criado", veiculo));
            }
        }
    }
}
