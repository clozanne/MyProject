using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MyProject
{
    public class Box
    {

        //You probably could have them in a static class, with static read-only properties.
        //only use const for internal/protected/private values
        //public static properties (with only a get) would be more common (perhaps backed by a private static readonly field).
        //what is a const? if you change the value of a const, you need to rebuild all the clients - but it can be faster, as it avoids a method call...
        //If the value will never change, then const is fine - Zero etc make reasonable consts ;p Other than that, static properties are more common.
        //const int a
        //        must be initialized.
        //        initialization must be at compile time.
        //readonly int a

        //can use a default value, without initializing.
        //initialization can be done at run time (Edit: within constructor only).
        //const fields. Do not use across assemblies (public or protected) if value might change in future because the value will be hardcoded at compile-time in those other assemblies. If you change the value, the old value will be used by the other assemblies until they are re-compiled.
        //Static variables are used to define constants because their values can be retrieved by invoking the class without creating an instance of it.


        //private int length;
        //private int width;
        //private int height;

        //public int Length
        //{
        //    get { return length; }

        //}

        //public int Width
        //{
        //    get { return width; }

        //}

        //public int Height
        //{
        //    get { return height; }

        //}

        //static Box1(int length, int width, int height)
        //{
        //    length = 42;
        //    width = 20;
        //    height = 12;
        //}

        public class Box1 : Cuboid
        {
            public Box1(int length, int width, int height) 
            {
                Length = 42;
                Width = 20;
                Height = 12;

            //public int length { get; protected set; } //should length be capitalised?
            //public int width { get; protected set; }
            //public int height { get; protected set; }
            }

        }
    }
}
