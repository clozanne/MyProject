using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class ChooseBox 
    {
        public Cuboid totalDimensionsNecessary;


        public ChooseBox(Cuboid totalDimensionsNecessary)
        {
            this.totalDimensionsNecessary = totalDimensionsNecessary;//in this case, totalDimensionsNeeded means that it has the value of the global totalDimensionsNeeded
        }

        Box1 box1 = new Box1(35, 25, 20);
        Box2 box2 = new Box2(45, 35, 16);
        Box3 box3 = new Box3(61, 46, 45);


        public Cuboid SelectBox()
        {

            if (totalDimensionsNecessary.Length > box1.Length)
            {
                if (totalDimensionsNecessary.Length > box2.Length)
                {
                    if (totalDimensionsNecessary.Length > box3.Length)
                    {
                        Console.WriteLine("Please seek alternative packaging");
                        Console.ReadLine();
                        return null;
                    }

                    else
                    {
                        Console.WriteLine("Choose box 3. Please wait while we check for stock...");

                        Box3 appropriateBox = new Box3(61, 46, 45);

                        return appropriateBox;


                    }


                }
                else
                {
                    Console.WriteLine("Choose box 2. Please wait while we check for stock...");

                    Box2 appropriateBox = new Box2(45, 35, 16);

                    return appropriateBox;
                }
            }
            else
            {
                Console.WriteLine("Choose box 1. Please wait while we check for stock...");

                Box1 appropriateBox = new Box1(35, 25, 20);

                return appropriateBox;

            }

        }

    }
}


