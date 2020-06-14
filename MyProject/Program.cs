using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace MyProject
{
    public class Program

  
    {
        public static void Main()
        {
            Console.WriteLine("How many items?");
            SetUp setup = new MyProject.SetUp();

            setup.GetAllCuboids();

            TotalVolume totalVolumeNeeded = new MyProject.TotalVolume(setup.items);

            if (setup.numberOfItem > 1) {
                totalVolumeNeeded.GetTotalVolumeNeeded();
            }
            else
            {
                totalVolumeNeeded.GetVolumeForOneItem();
            }
        }

    }
}

