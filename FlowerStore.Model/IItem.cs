using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerStore.Model
{
    public interface IItem
    {
        string Name { get; set; }
        float Price { get; set; }
        Image[] Images { get; set; }
    }
}
