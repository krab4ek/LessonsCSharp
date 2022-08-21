using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    internal class Car
    {
        protected int CurrentSpeed { get; set; }
        protected string? PetName { get; set; }

        public Car()
        {

        }
        public Car(string PetName, int CurrentSpeed)
        {
            this.PetName = PetName;
            this.CurrentSpeed = CurrentSpeed;
        }
        public override string ToString()
        
           => $"{PetName} is going  {CurrentSpeed} MPH!";
        
    }
}
