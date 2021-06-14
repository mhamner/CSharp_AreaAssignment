using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AreaAssignment
{
    public class Rectangle : Shape
    {
        public override int FindArea(string dimensions)
        {
            string[] dimensionsArray = dimensions.Split(',');

            //Since it's a rectangle, I don't need to loop through the array - I'll only have a length and a width
            int dimension1 = Convert.ToInt32(dimensionsArray[0].Trim());
            int dimension2 = Convert.ToInt32(dimensionsArray[1].Trim());

            //Find the area of the square by multiplying length * width
            return dimension1 * dimension2;
        }
    }
}
