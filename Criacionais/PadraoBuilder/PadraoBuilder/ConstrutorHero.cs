using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class ConstrutorHero : IConstrutorVeiculo
    {
        Veiculo veiculo = new Veiculo();

        public void AtribuirModelo()
        {
            this.veiculo.Modelo = "Hero";
        }

        public void AtribuirMotor()
        {
            this.veiculo.Motor = "4 cilindros";
        }

        public void AtribuirTransmissao()
        {
            this.veiculo.Transmissao = "120 km/h";
        }

        public void AtribuirCorpo()
        {
            this.veiculo.Corpo = "Plástico";
        }

        public void AtribuirAcessorios()
        {
            this.veiculo.Acessorios.Add("Banco de couro");
            this.veiculo.Acessorios.Add("Vidro elétrico");
        }

        public Veiculo ObterVeiculo()
        {
            return this.veiculo;
        }
    }
}
