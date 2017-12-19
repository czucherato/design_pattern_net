using PadraoAbstractFactory.Fabricas.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory.Fabricas.SqlServer
{
    public class SqlServerFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            /* A classe aqui ficou encapsulada */
            return new SqlServerConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlServerCommand();
        }
    }
}
