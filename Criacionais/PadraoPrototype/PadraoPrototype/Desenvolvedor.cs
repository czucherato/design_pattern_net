using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    public class Desenvolvedor : IEmpregado
    {
        public Desenvolvedor(string nome, string papel, string linguagemPreferia)
        {
            this.Nome = nome;
            this.Papel = papel;
            this.LinguagemPreferida = linguagemPreferia;
        }

        public int PalavrasPorMinuto { get; set; }
        public string Nome { get; set; }
        public string Papel { get; set; }
        public string LinguagemPreferida { get; set; }

        public IEmpregado Clonar()
        {
            // Shallow Copy: only top-level objets are duplicated
            return (IEmpregado)this.MemberwiseClone();

            // Deep Copy: all objects are duplicated
            // return (IEmpregado)this.Clone();
        }

        public string ObterDetalhes()
        {
            return string.Format("{0} - {1} - {2}", this.Nome, this.Papel, this.LinguagemPreferida);
        }
    }
}
