using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public abstract class FabricaVeiculo
    {
        public abstract IFabrica ObterVeiculo(string veiculo);
    }
}
