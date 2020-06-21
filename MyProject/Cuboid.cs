using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Cuboid
    {


        protected int length;
        protected int width;
        protected int height;

        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0)
                    length = value;
            }
        }

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
            }
        }

        public Cuboid(int l, int w, int h) //this is the constructor
        {
            this.length = l; //this means it refers to the length mentioned above on line 19
            this.width = w;
            this.height = h;
        }

        public Cuboid() { }

        //method here ??
        //worth noting that it is not necessary to add a method here to get volume
    }
}
