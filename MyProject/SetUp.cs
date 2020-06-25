using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    
    public class SetUp
    {

        public SetUp() {
            
        } // thinl about adding a constructor here

        //public int numberOfItem = Convert.ToInt32(Console.ReadLine());

        public int numberOfItem;

        public void GetTotalNumberOfItems()
        {
            //bool isNumeric = false;
           // string number;
            //bool num = false;
            do
            {
                string line = Console.ReadLine();
                //numberOfItem = Convert.ToInt32(Console.ReadLine());

                //number = Console.ReadLine();
                //bool result = Int32.TryParse(numberOfItem, out isNumeric);
                try
                {
                    numberOfItem = Int32.Parse(line);
                    // int numberOfItem = Int32.TryParse(number, out numberOfItem);

                    if (numberOfItem <= 0) //|| result = false) //|| !Int32.TryParse(numberOfItem, out num)
                    {
                        throw new BoxException();
                    }
                }
                catch (BoxException exception)
                {
                    Console.WriteLine(exception.Message + "\n" + numberOfItem +" is not a positive number. Please enter a positive number:");
                    numberOfItem = 0;
                }
                catch (FormatException formatException)
                {
                    // if (isNumeric = false)
                    {
                        Console.WriteLine(formatException.Message + "\n" + line + " is not an integer. Please enter an integer:");
                    }

                }

                
            }
            while (numberOfItem <= 0);
            GetAllCuboids(numberOfItem);
        }
            
   





        public Dictionary<string, Cuboid> items = new Dictionary<string, Cuboid>();

        public Dictionary<string, Cuboid> GetAllCuboids(int numberOfItem)
        {

            for (int i = 0; i < numberOfItem; i++)
            {
                Console.WriteLine("Please enter the dimensions of item " + (i + 1) + ":");
                int[] dimensions = GetInput();
                Console.Clear();
                int[] dimensionsSorted = ReturnSorted(dimensions);

                int length = GetLength(dimensionsSorted);
                int width = GetWidth(dimensionsSorted);
                int height = GetHeight(dimensionsSorted);

                Cuboid cuboid = new Cuboid(length, width, height);

                
                string name = "item" + (i + 1).ToString();
                items.Add(name, new Cuboid(length, width, height));
                
            }
            return items;
            
        }

       

        public int[] GetInput()
        {
            //Console.WriteLine("Please enter the dimensions of your item :");
            Console.WriteLine("Dimension 1:");
            int dimension1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dimension 2:");
            int dimension2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dimension 3:");
            int dimension3 = Convert.ToInt32(Console.ReadLine());

            int[] dimensions = new int[3];
            dimensions[0] = dimension1;
            dimensions[1] = dimension2;
            dimensions[2] = dimension3;

            return dimensions;


        }

        public int[] ReturnSorted(int[] dimensions)
        {
            int[] dimensionsSorted = dimensions.OrderBy((a) => a).ToArray();
            return dimensionsSorted;
        }


        int length;
        int width;
        int height;

        public int GetLength(int[] dimensionsSorted)
        {
            length = dimensionsSorted[2];

            return length;
        }

        public int GetWidth(int[] dimensionsSorted)
        {
            width = dimensionsSorted[1];

            return width;
        }

        public int GetHeight(int[] dimensionsSorted)
        {
            height = dimensionsSorted[0];

            return height;
        }
    }
}

