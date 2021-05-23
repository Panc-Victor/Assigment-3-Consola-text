using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3_Consola_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "This is my car!";

            string[] result = message.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Words count: {result.Length}");
        }
    }
}
