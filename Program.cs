namespace InterviewTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interview Task 2");
            //INPUTS = list of points and values plane equation [(x,y,z), ....] and [a,b,c,d]
            //OUTPUTS = Points over the plane and intersection points and POLYLINE!

            //Pseudocode
            // 1. Detect points above the plane
            // 2. Detect pair of points in oposite sites of the plane
            // 3. Calculate the intersection point
            // 4. Return Polyline + Points above and over the plane!

            // Test cases: Plane z=0, vertical plane and diagonal plane

            Console.WriteLine("Interview Task 1");
            //INPUTS = A string with whitespaces a sign +or- and digits
            //OUTPUTS = The integer number after the +or- symbol

            //Pseudocode
            // 1. Iterate ober the string to detect the +or- symbol to activate a flag
            // 2. Save next character in a list
            // 3. Continue itereting until end or caracter is not an integer
            // 4. CAsting to integer and return

            // Test cases: "", "     ", "    +38",  "    +c", "    +38c7",
        }
    }
}