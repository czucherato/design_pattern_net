using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class CriadorVeiculo
    {
        private readonly IConstrutorVeiculo _construtor;

        public CriadorVeiculo(IConstrutorVeiculo construtor)
        {
            this._construtor = construtor;
        }

        public void CriarVeiculo()
        {
            this._construtor.AtribuirModelo();
            this._construtor.AtribuirMotor();
            this._construtor.AtribuirCorpo();
            this._construtor.AtribuirTransmissao();
            this._construtor.AtribuirAcessorios();
        }

        public Veiculo ObterVeiculo()
        {
            return this._construtor.ObterVeiculo();
        }
    }
}
