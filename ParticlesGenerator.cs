using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appbigdata
{
    class ParticlesGenerator
    {

        public void GenerateParticles(int count)
        {
            String fileName = @"C:\opengl\data\random.xyz";
            int seed = (int)(System.DateTime.Now.Ticks / 1000);
            Random random = new Random(seed);

            StreamWriter writer = new StreamWriter(fileName);
            try
            {
                writer.WriteLine(count);
                writer.WriteLine("Random Particles");
                String[] particleTypes = new String[] { "C", "H" };
                int maxValue = count;
                for (int i = 0; i < count; i++)
                {
                    double x = random.Next(maxValue) * 0.01;
                    double y = random.Next(maxValue) * 0.01;
                    double z = random.Next(maxValue) * 0.001;
                    double v = random.NextDouble();
                    int index = v >= 0.5d ? 0 : 1;
                    writer.WriteLine(String.Format("{0} {1} {2} {3}", particleTypes[index], x, y, z));
                }
            }
            finally
            {
                writer.Close();
            }
            System.Console.WriteLine(String.Format("save to:{0}", fileName));


        }
    }
}
