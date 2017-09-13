using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Master");
            var obj = Directory.GetDirectories("/www/root");
            Console.WriteLine("Null");

        }
    }
}
