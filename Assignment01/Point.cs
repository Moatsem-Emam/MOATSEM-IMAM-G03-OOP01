using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal struct Point
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }

        #endregion

        #region Ctors
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Methods
        public void AddCordinates()
        {
            int xTemp, yTemp;
            bool a, b;

            do
            {
                Console.Write("Enter x: ");
                a = int.TryParse(Console.ReadLine(), out xTemp);
                Console.Write("Enter y: ");
                b = int.TryParse(Console.ReadLine(), out yTemp);
                if (a == true && b == true)
                {
                    this.x = xTemp;
                    this.y = yTemp;
                    Console.WriteLine("Entry success!.");
                    Console.WriteLine("");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter integers for both x and y.");
                }

            }
            while (true);
        }

        #endregion
    }
}
