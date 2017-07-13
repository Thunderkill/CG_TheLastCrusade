using System.Collections.Generic;

namespace LastCrusade
{
    public class Room : Locatable
    {
        public List<Route> routes = new List<Route>();

        public Room(int x, int y) : base(x,y) { }

        public void Add(Route route)
        {
            routes.Add(route);
        }

        public void Add(Direction input, Direction output)
        {
            routes.Add(new Route(input, output));
        }

        public Direction GetDirectionFromInput(Direction input)
        {
            foreach (Route route in routes)
            {
                if (route.In == input)
                {
                    return route.Out;
                }
            }
            return Direction.None;
        }

        public bool CanTraverseFromTo(Direction from, Direction to)
        {
            foreach (Route route in routes)
            {
                if (route.In == from && route.Out == to)
                {
                    return true;
                }
            }
            return false;
        }
    }
}