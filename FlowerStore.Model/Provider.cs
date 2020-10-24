using System;

namespace FlowerStore.Model
{
    public class Provider : ISubject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string[] PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime StartDateCooperation { get; set; }
    }
}