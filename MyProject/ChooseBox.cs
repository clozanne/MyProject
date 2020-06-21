using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class ChooseBox
    {
        public Cuboid totalDimensionsNeeded;

        public ChooseBox(Cuboid totalDimensionsNeeded)
        {
            this.totalDimensionsNeeded = totalDimensionsNeeded;//in this case, totalDimensionsNeeded means that it has the value of the global totalDimensionsNeeded
        }

        Box1 box1 = new Box1(35, 25, 20);
        Box2 box2 = new Box2(45, 35, 16);
        Box3 box3 = new Box3(61, 46, 45);


        public Cuboid SelectBox()
        {
            if (totalDimensionsNeeded.Length > box1.Length)
            {
                if (totalDimensionsNeeded.Length > box2.Length)
                {
                    if (totalDimensionsNeeded.Length > box3.Length)
                    {
                        Console.WriteLine("Please seek alternative packaging");
                        return null;
                    }
                    
                    else return box3;
                }
                else return box2;
            }
            else return box1;
        }


    }
}
