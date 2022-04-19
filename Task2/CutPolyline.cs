using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class CutPolyline
    {
        /* Function that returns the points above and on a plane, given a collection
         * of 3D points (polyline) and the coefficients of a plane (Ax + By + Cz + d).
         * Input: polylinePoints - List of arrays, where each array is a 3D point of the polyline.
         * Output: List of arrays - Each array is a 3D point of the polyline or the
         * 3D point of intersection of the polyline with the plane.
        */
        public static List<double[]> cutPolyline(List<double[]> polylinePoints, double[] planeCoefficients)
        {
            List<double[]> polylinePointsAbove = new List<double[]>();

            // Point of intersection of the line formed by two consecutive points of the 
            // polyline and the plane, iterating point to point
            double[] intersectingPoint;

            // The point of the previous iteration is stored. For the first iteration,
            // this will be the first value of the polyline.
            double[] previousPoint = polylinePoints[0];
            foreach (double[] point in polylinePoints)
            {
                // First iteration
                if (previousPoint == point)
                {
                    if (checkPointPosition(previousPoint, planeCoefficients) == "above" || checkPointPosition(previousPoint, planeCoefficients) == "in")
                    {
                        polylinePointsAbove.Add(previousPoint);
                    }
                    continue;
                }
                // Intersection detected: One point above and one point below the plane
                if (checkPointPosition(previousPoint, planeCoefficients) == "above" && checkPointPosition(point, planeCoefficients) == "below")
                {
                    intersectingPoint = getIntersectingPoint(previousPoint, point, planeCoefficients);
                    polylinePointsAbove.Add(intersectingPoint);
                    previousPoint = point;
                    continue;
                }
                // Intersection detected: One point below and one point above the plane
                if (checkPointPosition(previousPoint, planeCoefficients) == "below" && checkPointPosition(point, planeCoefficients) == "above")
                {
                    intersectingPoint = getIntersectingPoint(previousPoint, point, planeCoefficients);
                    polylinePointsAbove.Add(intersectingPoint);
                    polylinePointsAbove.Add(point);
                    previousPoint = point;
                    continue;
                }
                // Store point of iteration: Both points above the plane
                if (checkPointPosition(previousPoint, planeCoefficients) == "above" && checkPointPosition(point, planeCoefficients) == "above")
                {
                    polylinePointsAbove.Add(point);
                    previousPoint = point;
                    continue;
                }

                if (checkPointPosition(point, planeCoefficients) == "in")
                {
                    polylinePointsAbove.Add(point);
                    previousPoint = point;
                    continue;
                }

                previousPoint = point;

            }

            return polylinePointsAbove;
        }

        /* Function to detect whether a point is above, below or in a plane
         * Input: p: point's 3D coordinates 
         *        planeCoefficients: Plane coefficients A, B, C and d 
         * Output: position of p relative to the plane: "above", "below", "in"
         */
        public static string checkPointPosition(double[] p, double[] planeCoefficients)
        {
            //Solve the equation of the plane for the given point
            //  Ax + By + Cz + d = 0
            double position = planeCoefficients[0] * p[0] + planeCoefficients[1] * p[1] + planeCoefficients[2] * p[2] + planeCoefficients[3];
            string pointLocation = "";

            if (position > 0)
            {
                pointLocation = "above";
            }
            if (position < 0)
            {
                pointLocation = "below";
            }
            if (position == 0)
            {
                pointLocation = "in";
            }
            return pointLocation;
        }

        /* The intersectingPoint of a line with a plane is found by finding the t-value 
         * that solves the equation of the plane given the three parametric equations 
         * of the line passing through the points p1 and p2. 
         */
        public static double[] getIntersectingPoint(double[] p0, double[] p1, double[] planeCoefficients)
        {
            //Decomposition by coordinates and coefficients (points and plane respectively)
            double p0x = p0[0];
            double p0y = p0[1];
            double p0z = p0[2];

            double p1x = p1[0];
            double p1y = p1[1];
            double p1z = p1[2];

            double A = planeCoefficients[0];
            double B = planeCoefficients[1];
            double C = planeCoefficients[2];
            double d = planeCoefficients[3];

            double t;

            // The parametric equation of the line formed by p0 and p1 is described as follows:
            // {x = px0 + a*t ,y = py0 +b*t, z = pz0*c*t}
            // where a b and c are the coordinates of the vector director of the line


            // Coordinates of the director vector:
            double a = p1x - p0x;
            double b = p1y - p0y;
            double c = p1z - p0z;

            // Clearing the parameter t, by setting the parametric equations in the equation of the plane:
            // Ax + By + Cz + d = 0
            // A(px0 + a*t) + B(py0 + b*t) + C(pz0 + c*t) + d = 0


            t = -(A * p0x + B * p0y + C * p0z + d) / (A * a + B * b + C * c);

            // Coordinates of the intersection point given the parameter t:
            double[] intersectingPoint = { p0x + a * t, p0y + b * t, p0z + c * t };

            return intersectingPoint;
        }

    }
}