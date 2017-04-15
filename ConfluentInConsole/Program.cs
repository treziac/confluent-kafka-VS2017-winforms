using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfluentInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("librdakfka " + Confluent.Kafka.Library.VersionString + " correctly loaded");
        }
    }
}
