using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerStore.Model
{
    public interface IItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Image[] Images { get; set; }
    }
}
