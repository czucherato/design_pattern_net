using PadraoAbstractFactory.Fabricas.Comum;
using PadraoAbstractFactory.Fabricas.MongoDb;
using PadraoAbstractFactory.Fabricas.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aqui vamos instanciar a nossa sql factory */
            DbFactory sqlFactory = new SqlServerFactory();
            DbConnection sqlConnection = sqlFactory.CreateConnection();
            sqlConnection.Open();

            DbCommand sqlCommand = sqlFactory.CreateCommand();
            sqlCommand.Execute();

            /* Aqui vamos instanciar a nossa mongo factory */
            DbFactory mongoFactory = new MongoDbFactory();
            DbConnection mongoConnection = mongoFactory.CreateConnection();
            mongoConnection.Open();

            DbCommand mongoCommand = mongoFactory.CreateCommand();
            mongoCommand.Execute();

            Console.ReadLine();
        }
    }
}
