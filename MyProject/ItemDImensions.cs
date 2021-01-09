using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace MyProject
{
    [Table(Name = "ItemDimensions")]
    public class ItemDimension
    {
        private string _ItemId;
        [Column(IsPrimaryKey = true, Storage = "_ItemId")]
        public string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this._ItemId = value;
            }
        }

        private int _Length;
        [Column(Storage = "_Length")]
        public int Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                this._Length = value;
            }
        }

        private int _Width;
        [Column(Storage = "_Width")]
        public int Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this._Width = value;
            }
        }

        private int _Height;
        [Column(Storage = "_Height")]
        public int Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this._Height = value;
            }
        }
    }
}
