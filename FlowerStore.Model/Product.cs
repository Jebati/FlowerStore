namespace FlowerStore.Model
{
    public class Product : IItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Image[] Images { get; set; }
        public Type Type { get; set; }
        public Provider Provider { get; set; }
    }
}