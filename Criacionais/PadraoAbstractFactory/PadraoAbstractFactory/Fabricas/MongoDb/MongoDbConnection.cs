using PadraoAbstractFactory.Fabricas.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory.Fabricas.MongoDb
{
    public class MongoDbConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("&amp;amp;amp;amp;quot;Método Open de Mongo Connection foi chamado...&amp;amp;amp;amp;quot;");
        }
    }
}
