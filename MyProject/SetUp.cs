using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace MyProject
{
    
    public class SetUp
    {


    public SetUp() {
            
        } 

        public int numberOfItem; 
        public string line;
        private int dimension;
        private string dimensionsString; 

        
        public void GetTotalNumberOfItems(string line)
        {

                try
                {
                    numberOfItem = Int32.Parse(line);

                    if (numberOfItem <= 0) 
                    {
                        throw new BoxException();
                    }
                }
                catch (BoxException exception)
                {
                    Console.WriteLine(exception.Message + "\n" + numberOfItem +" is not a positive number. Please enter a positive number:");
                
                }
                catch (FormatException formatException)
                {

                    {
                        Console.WriteLine(formatException.Message + "\n" + line + " is not an integer. Please enter an integer:");
                        numberOfItem = 0;
                }

                }

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

        //public Dictionary<string, Cuboid> GetBoxFromID(int numberOfItem)
        //{
        //    //    IQueryable<ItemDimension> itemQuery =
        //    //    from dimensionItem in ItemDimensions
        //    //    where dimensionItem.ItemId == "VARIABLE HERE"
        //    //    select ;

        //    //    //IQueryable<Customer> custQuery =
        //    //    //from cust in Customers
        //    //    //where cust.City == "London"
        //    //    //select cust;


        //    DataContext db = new DataContext
        //    (@"FilePath");
        //    Table<ItemDimension> ItemDimensions = db.GetTable<ItemDimension>();
        //    db.Log = Console.Out;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        //    IQueryable<ItemDimension> itemQuery =
        //    from dimensionItem in ItemDimensions
        //    where dimensionItem.ItemId == "VARIABLE HERE"
        //    select dimensionItem;

        //    foreach (ItemDimension dimensionItem in itemQuery)
        //    {
        //        Console.WriteLine("Length={0}, Width={1}, Height={2}", dimensionItem.ItemId,
        //            dimensionItem.Length, dimensionItem.Width, dimensionItem.Height);
        //    }

        //    Cuboid cuboid = new Cuboid(length, width, height);


        //    string name = "item" + (i + 1).ToString();
        //    items.Add(name, new Cuboid(length, width, height));

        //    return items;
        //}


        public int[] GetInput()
        {
            
            int[] dimensions = new int[3];
            for (int i = 0; i < dimensions.Length;)
            {
                try
                {
                    Console.WriteLine("Dimension " + (i + 1) + ":");
                    dimensionsString = Console.ReadLine();
                    dimension = Int32.Parse(dimensionsString);

                    if (dimension <= 0)
                    {
                        throw new BoxException();
                    }
                    else
                    {
                        dimensions[i++] = dimension;
                    }
                }

                catch (BoxException exception)
                {
                    Console.WriteLine(exception.Message + "\n" + dimensionsString + " is not a positive number. Please enter a positive number:");
                   
                }

                catch (FormatException formatException)
                {

                    {
                        Console.WriteLine(formatException.Message + "\n" + dimensionsString + " is not an integer. Please try again. Only positive integers. If not an integer please round to the nearest whole number:");
                    }

                }
            }


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

