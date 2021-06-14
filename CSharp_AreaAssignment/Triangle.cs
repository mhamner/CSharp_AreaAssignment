using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_AreaAssignment
{
    public class Triangle : Shape
    {
        public override int FindArea(string dimensions)
        {
            string[] dimensionArray = dimensions.Split(',');

            //Since it's a triangle, I don't need to loop through the array - I'll just get 2 dimensions (base and height)
            int dimension1 = Convert.ToInt32(dimensionArray[0]);
            int dimension2 = Convert.ToInt32(dimensionArray[1]);

            //Determine the area of the triangle ((base * height) / 2)
            return (dimension1 * dimension2) / 2;
        }
    }
}
