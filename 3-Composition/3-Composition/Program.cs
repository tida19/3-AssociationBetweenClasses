using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigertor = new DbMigertor(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigertor.Migrate();
            installer.Install();
            Console.ReadKey();
        }
    }
}
