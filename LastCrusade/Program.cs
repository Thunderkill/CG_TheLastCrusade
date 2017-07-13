using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCrusade
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();

            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // number of columns.
            int H = int.Parse(inputs[1]); // number of rows.
            for (int i = 0; i < H; i++)
            {
                string LINE = Console.ReadLine(); // represents a line in the grid and contains W integers. Each integer represents one room of a given type.
                string[] roomTypes = LINE.Split(' ');
                for (int h = 0; h < roomTypes.Length; h++)
                {
                    map.Add(h, i, roomTypes[h]);
                    Console.Error.WriteLine("Room Created {0}, {1}, {2}", h, i ,roomTypes[h]);
                }
            }
            int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).

            // game loop
            while (true)
            {
                inputs = Console.ReadLine().Split(' ');
                int XI = int.Parse(inputs[0]);
                int YI = int.Parse(inputs[1]);
                string POS = inputs[2];

                Direction dir = Direction.Top;
                if(POS == "RIGHT")
                    dir = Direction.Right;
                if(POS == "LEFT")
                    dir = Direction.Left;
                if(POS == "TOP")
                    dir = Direction.Top;


                Console.Error.WriteLine("My pos {0}, {1}, {2}", XI, YI, POS);
                Locatable getNextCoordinate = map.GetNextPositionFor(XI, YI, dir);

                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");


                // One line containing the X Y coordinates of the room in which you believe Indy will be on the next turn.
                Console.WriteLine(getNextCoordinate?.ToString() ?? "0 0");
            }
        }
    }
}
