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
            SetUp setup = new MyProject.SetUp();
            //int numberOfItem;

        Console.WriteLine("How many items?");

            do
            {

                string line = Console.ReadLine();
                setup.GetTotalNumberOfItems(line);
            }
            while (setup.numberOfItem <= 0);

            setup.GetAllCuboids(setup.numberOfItem);

            TotalDimensions totalDimensions = new TotalDimensions(setup.items);


            Cuboid totalDimensionsNeeded = new Cuboid(0, 0, 0);

            int[] newDimensions = totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);


            Rotate rotate = new Rotate(newDimensions);

            //Cuboid totalDimensionsNecessary = totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);

            Cuboid totalDimensionsNecessary = rotate.GetCuboid(newDimensions);

            Cuboid appropriateBox = new Cuboid(0, 0, 0);

            ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);


            Cuboid neededBox = chooseBox.GetCuboid();

            StockChecker stockChecker = new StockChecker();

            stockChecker.CheckIfBoxIsInStock(neededBox);



        }

    }
}

