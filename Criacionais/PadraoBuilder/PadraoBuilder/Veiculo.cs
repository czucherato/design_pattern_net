using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Motor { get; set; }
        public string Transmissao { get; set; }
        public string Corpo { get; set; }
        public List<string> Acessorios { get; set; }

        public Veiculo()
        {
            this.Acessorios = new List<string>();
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Motor: {0}", this.Motor);
            Console.WriteLine("Corpo: {0}", this.Corpo);
            Console.WriteLine("Transmissão: {0}", this.Transmissao);
            Console.WriteLine("Acessórios:");

            foreach (string acessorio in this.Acessorios)
                Console.WriteLine("\t{0}", acessorio);
        }
    }
}
