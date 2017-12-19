using PadraoAbstractFactory.Fabricas.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory.Fabricas.MongoDb
{
    public class MongoDbFactory : DbFactory
    {
        public override DbConnection CreateConnection()
        {
            return new MongoDbConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new MongoDbCommand();
        }
    }
}
