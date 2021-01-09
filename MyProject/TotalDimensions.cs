using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class TotalDimensions 
    {
        public Dictionary<string, Cuboid> items;


        //public Cuboid totalDimensionsNeeded { get; set; }  


        public TotalDimensions(Dictionary<string, Cuboid> items)
        {
            this.items = items;
        }

        //Box1 box1 = new Box1(35, 25, 20);
        //Box2 box2 = new Box2(45, 35, 16);
        //Box3 box3 = new Box3(61, 46, 45);


        public int[] GetTotalDimensionsNeeded(int numberOfItem)
        {
            int[] newDimensions = new int[3];
            int[] potentialDimensions1 = new int[3];
            int[] potentialDimensions2 = new int[3];
            int volume1;
            int volume2;

            if (numberOfItem > 1)
            {
               
                    for (int i = 0; i < potentialDimensions1.Length; i++)
                    {

                        potentialDimensions1[i++] = items.Max(r => r.Value.Length);

                        potentialDimensions1[i++] = items.Sum(r => r.Value.Width);

                        potentialDimensions1[i++] = items.Max(r => r.Value.Height);
                    }


                
                    for (int i = 0; i < potentialDimensions2.Length; i++)
                    {

                        potentialDimensions2[i++] = items.Max(r => r.Value.Length);

                        potentialDimensions2[i++] = items.Max(r => r.Value.Width);

                        potentialDimensions2[i++] = items.Sum(r => r.Value.Height);


                    }

                volume1 = potentialDimensions1[0] * potentialDimensions1[1] * potentialDimensions1[2];

                volume2 = potentialDimensions2[0] * potentialDimensions2[1] * potentialDimensions2[2];

                if (volume1 <= volume2) //potentially change this sign kater
                {


                    newDimensions = potentialDimensions1;

                    return newDimensions;
                }
                else {

                    newDimensions = potentialDimensions2;

                    return newDimensions;

                }

                
                
            }
            else
            {
                for (int i = 0; i < newDimensions.Length; i++)
                {
                    newDimensions[i++] = items.Where(r => r.Key.Equals("item1")).Select(n => n.Value.Length).FirstOrDefault();

                    newDimensions[i++] = items.Where(r => r.Key.Equals("item1")).Select(n => n.Value.Width).FirstOrDefault();

                    newDimensions[i++] = items.Where(r => r.Key.Equals("item1")).Select(n => n.Value.Height).FirstOrDefault();


                }
                return newDimensions;

            }



        }

    }
}
