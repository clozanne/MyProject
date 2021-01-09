using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class ChooseBox : CuboidCreator
    {
        public Cuboid totalDimensionsNecessary;


        public ChooseBox(Cuboid totalDimensionsNecessary)
        {
            this.totalDimensionsNecessary = totalDimensionsNecessary;//in this case, totalDimensionsNeeded means that it has the value of the global totalDimensionsNeeded
        }

        //Cuboid box1 = new Cuboid(0, 0, 0);
        //Cuboid box2 = new Cuboid(0, 0, 0);
        //Cuboid box3 = new Cuboid(0, 0, 0);



        //Box1 box1 = new Box1(0, 0, 0);
        readonly Cuboid box1 = GetBox(1);
        readonly Cuboid box2 = GetBox(2);
        readonly Cuboid box3 = GetBox(3);
        
        //Box1 box1 = new Box1(35, 25, 20);
        //Box2 box2 = new Box2(45, 35, 16);
        //Box3 box3 = new Box3(61, 46, 45);

        public static Cuboid GetBox(int y)
        {
            Cuboid box1 = new Cuboid(0, 0, 0);
            Cuboid box2 = new Cuboid(0, 0, 0);
            Cuboid box3 = new Cuboid(0, 0, 0);
            string jsonpath = "";
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            

            if (y == 1) 
            { jsonpath = @"Box1Dimensions.json";
                string absolutePath = Path.Combine(currentDirectory, jsonpath);
                var json = File.ReadAllText(absolutePath);
                box1 = JsonConvert.DeserializeObject<Cuboid>(json);
                return box1;
            }
            if (y == 2) 
            { jsonpath = @"Box2Dimensions.json";
                string absolutePath = Path.Combine(currentDirectory, jsonpath);
                var json = File.ReadAllText(jsonpath);
                box2 = JsonConvert.DeserializeObject<Cuboid>(json);
                return box2;
            }
            else { jsonpath = @"Box3Dimensions.json";
                string absolutePath = Path.Combine(currentDirectory, jsonpath);
                var json = File.ReadAllText(jsonpath);
                box3 = JsonConvert.DeserializeObject<Cuboid>(json);
                return box3;
            }
            
        }
            
            

           
        
        //public static Cuboid GetBox()
        //{
        //    Cuboid box1 = new Cuboid(0, 0, 0);
        //    Cuboid box2 = new Cuboid(0, 0, 0);
        //    Cuboid box3 = new Cuboid(0, 0, 0);
        //    string jsonpath = @"C:\Users\ozcmt3\source\repos\MyProject\MyProject\BoxDimensions.json";
        //    using (StreamReader r = new StreamReader(jsonpath)) {
        //        string jStr = r.ReadToEnd();
        //        dynamic json = JValue.Parse(jStr);
        //        foreach (var x in json)
        //        {
        //            if (x.Name == "Box1")
        //            {
        //                box1.length = x.Dimensions.length;
        //                box1.width = x.Dimensions.width;
        //                box1.height = x.Dimensions.height;

        //                return box1;
        //            }


        //            else if (x.Name == "Box2")
        //            {
        //                box2.length = x.Dimensions.length;
        //                box2.width = x.Dimensions.width;
        //                box2.height = x.Dimensions.height;

        //                return box2;

        //            }


        //            else if (x.Name == "Box3")
        //            {
        //                box3.length = x.Dimensions.length;
        //                box3.width = x.Dimensions.width;
        //                box3.height = x.Dimensions.height;

        //                return box3;
        //            }
                    
        //        }

        //        return box3;

        //    }
        //    //JsonConvert.PopulateObject(jsonpath, box1);
        //}


        public override Cuboid GetCuboid()
        {

            if ((totalDimensionsNecessary.Length < box1.Length) && (totalDimensionsNecessary.Height < box1.Height) && (totalDimensionsNecessary.Width < box1.Width))
            {
                Console.WriteLine("Choose box 1. Please wait while we check for stock...");


                Box1 appropriateBox = new Box1(0,0,0);

                return appropriateBox;

               
            }
            else if ((totalDimensionsNecessary.Length < box2.Length) && (totalDimensionsNecessary.Height < box2.Height) && (totalDimensionsNecessary.Width < box2.Width))
            {
                Console.WriteLine("Choose box 2. Please wait while we check for stock...");

                Box2 appropriateBox = new Box2(0,0,0);

                return appropriateBox;
            }
            else if ((totalDimensionsNecessary.Length < box3.Length) && (totalDimensionsNecessary.Height < box3.Height) && (totalDimensionsNecessary.Width < box3.Width))
            {
                Console.WriteLine("Choose box 3. Please wait while we check for stock...");

                Box3 appropriateBox = new Box3(0,0,0);

                return appropriateBox;
            }
            else {
                Console.WriteLine("Please seek alternative packaging");
                Console.ReadLine();
                return null;
            }
        }
    }
}



