namespace FlowerStore.Model
{
    public class Service : IItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Image[] Images { get; set; }
    }
}