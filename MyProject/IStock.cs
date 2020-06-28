using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public interface IStock
    {
        //string CheckIfBoxIsInStock(Box1 appropriateBox);

        //string CheckIfBoxIsInStock(Box2 appropriateBox);

        //string CheckIfBoxIsInStock(Box3 appropriateBox);

        void CheckIfBoxIsInStock(Cuboid neededBox);

    }
}
