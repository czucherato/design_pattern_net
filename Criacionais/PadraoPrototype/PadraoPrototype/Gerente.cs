using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    public class Gerente
    {
        private Dictionary<string, IEmpregado> _empregados = new Dictionary<string, IEmpregado>();

        // Indexador
        public IEmpregado this[string chave]
        {
            get { return _empregados[chave]; }
            set { _empregados.Add(chave, value); }
        }
    }
}
