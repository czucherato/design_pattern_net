using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoSingleton
{
    public sealed class Singleton
    {
        public Singleton()
        {
            // Initialize.
        }

        static readonly Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
