using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Rotate : CuboidCreator
    {

        int[] newDimensions;

        public Rotate(int[] newDimensions)
        {
            this.newDimensions = newDimensions;
        }

            SetUp setup = new MyProject.SetUp();

        //public Cuboid RotateCuboid(int[] newDimensions)
        //{

        //    int[] dimensionsSorted = setup.ReturnSorted(newDimensions);

        //    int length = setup.GetLength(dimensionsSorted);
        //    int width = setup.GetWidth(dimensionsSorted);
        //    int height = setup.GetHeight(dimensionsSorted);

        //    Cuboid rotatedCuboid = new Cuboid(length, width, height);

        //    return rotatedCuboid;



        //}


        public Cuboid GetCuboid(int[] newDimensions)
        {
            int[] dimensionsSorted = setup.ReturnSorted(newDimensions);

            int length = setup.GetLength(dimensionsSorted);
            int width = setup.GetWidth(dimensionsSorted);
            int height = setup.GetHeight(dimensionsSorted);

            Cuboid rotatedCuboid = new Cuboid(length, width, height);

            return rotatedCuboid;

        }

        public override Cuboid GetCuboid()
        {
            Cuboid rotatedCuboid = new Cuboid(0,0,0);

            return rotatedCuboid;
        }
    }
}
