using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MyProject
{
    class StockChecker : IStock
    {

        private readonly Mock<IStock> stock;
        private bool isInStock;

        public StockChecker()
        {
            stock = new Mock<IStock>();
        }

        public bool CheckIfBoxIsInStock(Cuboid neededBox)
        {
            stock.Object.CheckIfBoxIsInStock(neededBox);
            return isInStock;
        }

  
        
        public Cuboid ChooseAvailableBox( Cuboid neededBox)
        {
            if (isInStock == false)
            {
                string box = neededBox.ToString();
                string boxNumberTemp = box.Substring(13);
                int boxNumber = Convert.ToInt32(boxNumberTemp);
                string nextBoxAvailable = "Box" + (boxNumber + 1).ToString();
                Console.WriteLine("Box is not in stock. Please choose " + nextBoxAvailable + ". Please wait while we check for stock of " +nextBoxAvailable + "...");
                if (nextBoxAvailable == "Box2")
                {
                    Box2 newBox = new Box2(0,0,0);

                    return newBox;
                }
                else
                {
                    Box3 newBox = new Box3(0,0,0);

                    return newBox;
                }
            }
            else
            {
                Console.WriteLine("Box is in stock");
                return null;
            }

          
        }

        public bool CheckIfNewBoxIsInStock(Cuboid newBox)
        {
            stock.Object.CheckIfBoxIsInStock(newBox);
            return isInStock;
        }

    }
}
