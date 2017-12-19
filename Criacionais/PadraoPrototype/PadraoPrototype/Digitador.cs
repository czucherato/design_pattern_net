using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    public class Digitador : IEmpregado
    {
        public Digitador(string nome, string papel, int palavrasPorMinuto)
        {
            this.Nome = nome;
            this.Papel = papel;
            this.PalavrasPorMinuto = palavrasPorMinuto;
        }

        public int PalavrasPorMinuto { get; set; }
        public string Nome { get; set; }
        public string Papel { get; set; }

        public IEmpregado Clonar()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IEmpregado)this.MemberwiseClone();

            // Deep Copy: all objects are duplicated
            // return (IEmpregado)this.Clone();
        }

        public string ObterDetalhes()
        {
            return string.Format("{0} - {1} - {2}ppm", this.Nome, this.Papel, this.PalavrasPorMinuto);
        }
    }
}
