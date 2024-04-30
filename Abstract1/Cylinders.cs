using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cylinders:Shape
    {
        public  double Radius{get;set;}
        public double Width{get;set;}
        public double Height{get;set;}
        public override double CalculateArea()
        {
            
            Area=2*3.14*Radius*(Radius+Height);
            return Area;
        }
        public override double CalculateVolume()
        {
           Volume=3.14*Radius*Radius*Height;
           return Volume;
        }
    }
}