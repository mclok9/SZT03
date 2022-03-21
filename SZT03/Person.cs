﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZT03
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime MotherBirthDate { get; set; }
        public string MotherName { get; set; }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Price { get; set; }
    }
}
