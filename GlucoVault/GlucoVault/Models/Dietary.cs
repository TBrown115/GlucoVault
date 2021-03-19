﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GlucoVault.Models
{
    public class Dietary
    {
        public string Name { get; set; }
        public string Breakfast { get; set; }
        public string Lunch { get; set; }
        public string Snack { get; set; }
        public int Calories { get; set; }
        public string Dinner { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
