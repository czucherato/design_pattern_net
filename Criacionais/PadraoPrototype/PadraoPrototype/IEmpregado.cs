using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    public interface IEmpregado
    {
        IEmpregado Clonar();
        string ObterDetalhes();
    }
}
