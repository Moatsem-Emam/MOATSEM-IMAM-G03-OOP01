namespace Assignment01
{
    internal class Program
    {

        #region Q1_Methods
        public static double CalcDistance(Point p1, Point p2) 
        {
            return Math.Sqrt
                (
                    (p1.x - p2.x) * (p1.x - p2.x)
                    + (p1.y - p2.y) * (p1.y - p2.y)

                );
        }
        #endregion

        #region Q2_Methods
        public static Person OldestPerson(Person[] p)
        {
            Person oldest = p[0];
            for (int i = 1; i < p.Length; i++)
            {
                if (oldest.Age < p[i].Age)
                {
                    oldest = p[i];

                }
            }
            return oldest;
        }

        #endregion

        static void Main(string[] args)
        {

            #region Q1_Main
            //Point[] points = new Point[2];
            //points[0] = new Point();
            //points[1] = new Point();

            ////Add x , y
            ////for point 1 & 2
            //Console.WriteLine("----------Point 1----------");
            //points[0].AddCordinates();
            //Console.WriteLine("----------Point 2----------");
            //points[1].AddCordinates();

            ////calculate distance between two points
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine($"The Distance: {CalcDistance(points[0], points[1])}");
            #endregion


            #region Q2_Main
            //Person[] persons = new Person[3];

            ////Add Persons
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"----------Person {i+1}---------");
            //    persons[i] = new Person();
            //    persons[i].AddPerson();
            //    Console.WriteLine("");
            //}

            //Console.WriteLine($"The Oldest Person: {OldestPerson(persons)}");
            #endregion


        }
    }
}
