using System;
using System.Collections.Generic;
using System.Text;

namespace CarUpcastingDowncasting.Models
{
  public class Bugatti : Brand 
  {
        public int HorsePower { get; set; } = 655;

        public override void Speed()
        {
            Console.WriteLine("Max Speed");
        }
    }
}
