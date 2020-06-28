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
            setup.GetTotalNumberOfItems();

            TotalDimensions totalDimensions = new TotalDimensions(setup.items);


            Cuboid totalDimensionsNeeded = new Cuboid(0, 0, 0);

            int[] newDimensions = totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);


            Rotate rotate = new Rotate(newDimensions);

            //Cuboid totalDimensionsNecessary = totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);

            Cuboid totalDimensionsNecessary = rotate.RotateCuboid(newDimensions);

            Cuboid appropriateBox = new Cuboid(0, 0, 0);

            ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);


            Cuboid neededBox = chooseBox.SelectBox();

            StockChecker stockChecker = new StockChecker();

            stockChecker.CheckIfBoxIsInStock(neededBox);



        }

    }
}

