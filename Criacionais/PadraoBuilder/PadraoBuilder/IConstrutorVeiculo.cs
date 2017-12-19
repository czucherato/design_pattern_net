using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public interface IConstrutorVeiculo
    {
        void AtribuirModelo();
        void AtribuirMotor();
        void AtribuirTransmissao();
        void AtribuirCorpo();
        void AtribuirAcessorios();

        Veiculo ObterVeiculo();
    }
}
