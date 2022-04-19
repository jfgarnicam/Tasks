using System;
namespace Task_2
{
    class Task_2
    {
        static void Main(string[] args)
        {
            // Collection of 3D test points
            List<double[]> polylinePoints = new List<double[]>
            {
                new double[] { 2, 0, 0 },
                new double[] { 0, 0,  0 },
                new double[] { 0, 2,  0 },
                new double[] { 2, 0, 0 }
            };
            // test plane
            double[] planeCoefficients = { 1, 1, 0, -1 };

            // Intersecting Point between points polylinePoints[0] and polylinePoints[1]
            double[] intersectingPoint =  { 0, 0, 0 };

            // The first and second points of the collection are at the top and bottom respectively,
            // so there must be an intersection.
            TestCutPolyline.TestGetIntersectingPoint(polylinePoints[0], polylinePoints[1], planeCoefficients);

            // The first point of the collection is on the plane
            TestCutPolyline.TestCheckPointPosition(polylinePoints[0],  planeCoefficients, "above");

            // Executing the function 
            foreach (double[] point in CutPolyline.cutPolyline(polylinePoints, planeCoefficients))
            {
                Console.Write(point[0]);
                Console.Write(" ");
                Console.Write(point[1]);
                Console.Write(" ");
                Console.Write(point[2]);
                Console.WriteLine();
            }

        }
    }
}
