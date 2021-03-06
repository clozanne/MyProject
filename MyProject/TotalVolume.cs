﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class TotalVolume
    {
        private Dictionary<string, Cuboid> items;
        public TotalVolume(Dictionary<string, Cuboid> items)
        {
            this.items = items;
        }



        ////do all the properties
        //private int length;
        //private int width;
        //private int height;

        //public TotalVolume(int l, int w, int h) //this is the constructor
        //{
        //    this.length = l; //this means it refers to the length mentioned above on line 13
        //    this.width = w;
        //    this.height = h;
        //}

        //public int Length
        //{
        //    get { return length; }
        //    set
        //    {
        //        if (value > 0)
        //            length = value;
        //    }
        //}

        //public int Width
        //{
        //    get { return width; }
        //    set
        //    {
        //        if (value > 0)
        //            width = value;
        //    }
        //}

        //public int Height
        //{
        //    get { return height; }
        //    set
        //    {
        //        if (value > 0)
        //            height = value;
        //    }
        //}






        public Cuboid GetTotalVolumeNeeded()
        {


            int length = items.Max(r => r.Value.Length);

            int width = items.Max(r => r.Value.Width);

            int height = 0;

            foreach (var item in items.Values)
            {
                
                height += item.Height;
            }

            Cuboid totalVolumeNeeded = new Cuboid(length, width, height);

            return totalVolumeNeeded;
        }

        public Cuboid GetVolumeForOneItem()
        {
            int length = items.Where(r => r.Key.Equals("item1")).Select(n => n.Value.Length).FirstOrDefault();

            int width = items.Where(r => r.Key.Equals("item1")).Select(n => n.Value.Width).FirstOrDefault();

            int height = items.Where(r => r.Key.Equals("item1")).Select(n => n.Value.Height).FirstOrDefault();

            Cuboid volumeOneItem = new Cuboid(length, width, height);

            return volumeOneItem;
        }
    }
}
