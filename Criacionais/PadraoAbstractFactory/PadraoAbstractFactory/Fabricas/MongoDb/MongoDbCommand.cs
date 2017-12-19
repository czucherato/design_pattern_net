using PadraoAbstractFactory.Fabricas.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory.Fabricas.MongoDb
{
    public class MongoDbCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("&amp;amp;amp;amp;quot;Executando o comando do mongo.....&amp;amp;amp;amp;quot;");
        }
    }
}
