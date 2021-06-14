using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AreaAssignment
{
    public class Square : Shape
    {
        public override int FindArea(string dimensions)
        {
            //For the square, we're just going to have all the dimensions the same
            int side = Convert.ToInt32(dimensions);

            //Get the area of the square by multiplying side * side
            return side * side;
        }
    }
}
