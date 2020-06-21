using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

//in documentation state that you never find the total volume as unecessary

namespace MyProject
{
    public class Program

  
    {
        public static void Main()
        {
            Console.WriteLine("How many items?");
            SetUp setup = new MyProject.SetUp();
            setup.GetAllCuboids();

            //TotalDimensions totalDimensions = new TotalDimensions(setup.items);
            TotalDimensions totalDimensions = new TotalDimensions();
            totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);

            ChooseBox chooseBox = new ChooseBox(totalDimensions.totalDimensionsNeeded);


            //chooseBox.SelectBox();


        }

    }
}

