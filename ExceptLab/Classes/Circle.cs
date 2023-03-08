using ExceptLab.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptLab.Classes
{
    internal class Circle
    {

        public double Radius { get; set; }

        public override string ToString()
        {
            return this.Radius.ToString();
        }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException(radius);
            }

            Radius = radius;
        }
    }
}
