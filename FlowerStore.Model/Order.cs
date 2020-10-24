
using System;

namespace FlowerStore.Model
{
    public interface IOrder
    {
        public Client Client { get; set; }
        public Service Service { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class OrderByAddress : IOrder
    {
        public Client Client { get; set; }
        public Service Service { get; set; }
        public string ReceivingAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReceivingDate { get; set; }
        public float ReceivingPrice { get; set; }
    }

    public class OrderInShop : IOrder
    {
        public Client Client { get; set; }
        public Service Service { get; set; }
        public DateTime OrderDate { get; set; }
    }
}