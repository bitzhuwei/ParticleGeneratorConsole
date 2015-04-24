using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleGeneratorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            var g = new appbigdata.ParticlesGenerator();
            g.GenerateParticles(1000 * 1000);
            Console.WriteLine("Done!");
            Console.ReadKey(true);
        }
    }
}
