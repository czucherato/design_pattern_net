using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<Usuario> objectPool = new ObjectPool<Usuario>();
            Usuario usuario = objectPool.Get();
            objectPool.Release(usuario);
            Console.Read();
        }
    }
}
