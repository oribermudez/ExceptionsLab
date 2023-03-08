using ExceptLab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double positiveRadius = 100;
            double negativeRadius = -100;
            double zeroRadius = 0;

            Circle positiveCircle = new Circle(positiveRadius);

            try
            {
                Circle negativeCircle = new Circle(negativeRadius);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle zeroCircle = new Circle(zeroRadius);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
