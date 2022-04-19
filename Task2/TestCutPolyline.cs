using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class TestCutPolyline
    {
        /* Function to test if the function reports the correct position of a 3D point and a plane.
         * Input: A 3D point and the coefficients of the plane 
         * Output: String position of the point "above", "below" or "in".
         */
        public static void TestCheckPointPosition(double[] p, double[] planeCoefficients, string test)
        {
            if (CutPolyline.checkPointPosition(p, planeCoefficients).Equals(test))
            {
                Console.WriteLine("Check point position test passed");
            }
            else 
            {
                Console.WriteLine("Check point position test failed");
            }
        }
}
}