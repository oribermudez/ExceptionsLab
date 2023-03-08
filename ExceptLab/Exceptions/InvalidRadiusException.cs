using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptLab.Exceptions
{
    internal class InvalidRadiusException : Exception
    {
        public double Radius { get; set; }

        public InvalidRadiusException() : base("Invalid radius") { }

        public InvalidRadiusException(double radius) : base("Invalid radius: " + radius)
        {
            this.Radius = radius;
        }
    }
}
