﻿using System;

namespace FlowerStore.Model
{
    public class Client : ISubject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string[] PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }
    }
}