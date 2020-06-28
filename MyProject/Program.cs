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
            //setup.GetAllCuboids();

            TotalDimensions totalDimensions = new TotalDimensions(setup.items);

            //TotalDimensions totalDimensions = new TotalDimensions();

            Cuboid totalDimensionsNeeded = new Cuboid(0, 0, 0);
            //Cuboid appropriateBox = new Cuboid(0, 0, 0);

            Cuboid totalDimensionsNecessary = totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);

            //totalDimensions.GetTotalDimensionsNeeded(setup.numberOfItem);

            Cuboid appropriateBox = new Cuboid(0, 0, 0);

            ChooseBox chooseBox = new ChooseBox(totalDimensionsNecessary);

           // Cuboid neededBox = new Cuboid(0, 0, 0);

            Cuboid neededBox = chooseBox.SelectBox();

            StockChecker stockChecker = new StockChecker();

            stockChecker.CheckIfBoxIsInStock(neededBox);

            

            //stockChecker.CheckIfBoxIsInStock(neededBox);

            //stockChecker.CheckStock(neededBox);

            //chooseBox.CheckStock(neededBox);

            //StockChecker stockChecker = new StockChecker();

            //IStock stock;

            //public ChooseBox(IStock stockChecker)
            //{
            //    stock = stockChecker;
            //}

            //public void CheckStock(Cuboid neededBox)
            //{
            //    // Box1 appropriateBox = new Box1(35, 25, 20);
            //    stock.CheckIfBoxIsInStock(neededBox);
            //}





            //chooseBox.SelectBox();

            // chooseBox.CheckStock(Cuboid appropriateBox);


        }

    }
}

