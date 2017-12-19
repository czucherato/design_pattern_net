using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class ConstrutorHonda : IConstrutorVeiculo
    {
        Veiculo veiculo = new Veiculo();

        public void AtribuirModelo()
        {
            this.veiculo.Modelo = "Honda";
        }

        public void AtribuirMotor()
        {
            this.veiculo.Motor = "8 cilindros";
        }

        public void AtribuirTransmissao()
        {
            this.veiculo.Transmissao = "125 km/h";
        }

        public void AtribuirCorpo()
        {
            this.veiculo.Corpo = "Plástico";
        }

        public void AtribuirAcessorios()
        {
            this.veiculo.Acessorios.Add("Ar condicionado");
            this.veiculo.Acessorios.Add("direção hirdráulica");
        }

        public Veiculo ObterVeiculo()
        {
            return this.veiculo;
        }
    }
}
