using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();

            gerente["dev1"] = new Desenvolvedor("João", "SR", "C#");
            gerente["dev2"] = new Desenvolvedor("José", "JR", "PHP");
            gerente["dev3"] = new Desenvolvedor("Antônio", "PL", "Java");

            gerente["dig1"] = new Digitador("Maria", "SR", 300);
            gerente["dig2"] = new Digitador("Eduarda", "JR", 100);
            gerente["dig3"] = new Digitador("Camila", "PL", 200);

            Desenvolvedor desenvolvedor4 = (Desenvolvedor)gerente["dev1"].Clonar();
            desenvolvedor4.Nome = "Fabrício";

            Digitador digitador4 = (Digitador)gerente["dig1"].Clonar();
            digitador4.Nome = "Bruna";

            Console.WriteLine(desenvolvedor4.ObterDetalhes());
            Console.WriteLine(digitador4.ObterDetalhes());
            Console.ReadKey();
        }
    }
}
