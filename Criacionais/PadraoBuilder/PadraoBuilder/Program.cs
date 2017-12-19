using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CriadorVeiculo criadorVeiculo = new CriadorVeiculo(new ConstrutorHero());
            criadorVeiculo.CriarVeiculo();
            Veiculo veiculo = criadorVeiculo.ObterVeiculo();
            veiculo.ExibirInformacoes();

            Console.WriteLine("--------------------------------------");

            criadorVeiculo = new CriadorVeiculo(new ConstrutorHonda());
            criadorVeiculo.CriarVeiculo();
            veiculo = criadorVeiculo.ObterVeiculo();
            veiculo.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
