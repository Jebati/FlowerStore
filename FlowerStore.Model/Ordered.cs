using System;

namespace FlowerStore.Model
{
    public class Ordered
    {
        public IOrder Order { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
    }
}
