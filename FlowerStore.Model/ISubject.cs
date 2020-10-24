using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerStore.Model
{
    public interface ISubject
    {
        string Name { get; set; }
        string Address { get; set; }
        string[] PhoneNumber { get; set; }
        string Email { get; set; }
    }
}
