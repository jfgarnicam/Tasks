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

        /* Function to test if the intersection point obtained by the function "getIntersectionPoint" 
         * is actually inside the plane. The equation of the plane at the returned point is evaluated, 
         * if the result is 0, the test is passed. 
         */
        public static void TestGetIntersectingPoint(double[] p0, double[] p1, double[] planeCoefficients)
        {
            double[] intersectingPoint = CutPolyline.getIntersectingPoint(p0, p1, planeCoefficients);

            //Plane coefficients
            double A = planeCoefficients[0];
            double B = planeCoefficients[1];
            double C = planeCoefficients[2];
            double d = planeCoefficients[3];

            // Coordinates of the intersecting point
            double x = intersectingPoint[0];
            double y = intersectingPoint[1];
            double z = intersectingPoint[2];


            if ( (A*x + B*y + C*z + d) == 0 )
            {
                Console.WriteLine("Get intersecting point Test passed");
            }
            else 
            {
                Console.WriteLine("Get intersecting point Test failed");
            }

        }


}
}