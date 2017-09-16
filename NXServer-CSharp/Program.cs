using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;

namespace NXServer_CSharp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the server!");
            Console.ReadKey();
            Console.WriteLine();

            var appServer = new AppServer();
            if (!appServer.Setup(2017))
            {
                Console.WriteLine("Fail to setup");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            if (!appServer.Start())
            {
                Console.WriteLine("Fail to start");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("The server started successfully, press key 'q' to stop it!");
            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine();
                continue;
            }
            appServer.Stop();
            Console.WriteLine("The server was stoped!");
            Console.ReadKey();
        }
    }
}
