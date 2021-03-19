using SQLite;
using System;

namespace Todo
{
    public class VitalSignsItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        public decimal BloodLevel { get; set; }
        public decimal GlucLevel { get; set; }
        
        public DateTime CreatedOn { get; set; }
        public bool Done { get; set; }
    }

   
}

