using System;
using System.Collections.Generic;
using System.Linq;
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

        //public Cuboid neededBox;

        //IStock stock;

        //public StockChecker(IStock stockChecker)
        //{
        //    stock = stockChecker;
        //}

        //private readonly IEnumerable<IStock> Stock;

        //public StockChecker(IEnumerable<IStock> stock)
        //{
        //    this.Stock = stock;
        //}

        //public IEnumerable<bool> CheckIfBoxIsInStock(Cuboid neededBox)
        //{   var isInStock = new bool();
        //    this.Stock.FirstOrDefault(x => x.CheckIfBoxIsInStock(neededBox));
        //    return isInStock;

        //}

        //    public StockChecker(Cuboid neededBox)
        //{
        //    neededBox = neededBox;
        //}

        //public void CheckStock(Cuboid neededBox)
        //{


        //    stock.CheckIfBoxIsInStock(neededBox);//error thrown here

        //}
        //uncimment this!
        //public bool CheckIfBoxIsInStock(Cuboid neededBox) 
        //{
        //    throw new NotImplementedException();
        //}
    }
}
