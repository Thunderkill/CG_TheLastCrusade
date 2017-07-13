using System;
using System.Collections.Generic;
using System.Linq;

namespace LastCrusade
{
    public class Map
    {
        List<Room> rooms = new List<Room>();

        public Room GetRoom(Locatable loc)
        {
            foreach (Room room in rooms)
            {
                if (room.Equals(loc))
                {
                    Console.Error.WriteLine("Found room: {0} {1}", room.x, room.y);
                    return room;
                }
            }
            return null;
        }

        public Locatable GetNextPositionFor(Locatable loc)
        {
            Room startingRoom = GetRoom(loc);
            return startingRoom.GetDirectionCoordinate(startingRoom.routes[0].Out);
        }

        public Locatable GetNextPositionFor(Locatable loc, Direction comingFrom)
        {
            Room room = GetRoom(loc);
            Direction dirToGo = room.GetDirectionFromInput(comingFrom);
            Locatable dirLoc = room.GetDirectionCoordinate(dirToGo);
            
            return dirLoc;
        }

        public Locatable GetNextPositionFor(int x, int y, Direction comingFrom)
        {
            Locatable loc = new Locatable(x,y);
            return GetNextPositionFor(loc, comingFrom);
        }

        public void Add(int x, int y, string type)
        {
            Room room = new Room(x, y);
            switch (type)
            {
                case "1":
                    room.Add(Direction.Top, Direction.Down);
                    room.Add(Direction.Left, Direction.Down);
                    room.Add(Direction.Right, Direction.Down);
                    break;
                case "2":
                    room.Add(Direction.Left, Direction.Right);
                    room.Add(Direction.Right, Direction.Left);
                    break;
                case "3":
                    room.Add(Direction.Top, Direction.Down);
                    break;
                case "4":
                    room.Add(Direction.Top, Direction.Left);
                    room.Add(Direction.Right, Direction.Down);
                    break;
                case "5":
                    room.Add(Direction.Top, Direction.Right);
                    room.Add(Direction.Left, Direction.Down);
                    break;
                case "6":
                    room.Add(Direction.Left, Direction.Right);
                    room.Add(Direction.Right, Direction.Left);
                    break;
                case "7":
                    room.Add(Direction.Right, Direction.Down);
                    room.Add(Direction.Top, Direction.Down);
                    break;
                case "8":
                    room.Add(Direction.Right, Direction.Down);
                    room.Add(Direction.Left, Direction.Down);
                    break;
                case "9":
                    room.Add(Direction.Left, Direction.Down);
                    room.Add(Direction.Top, Direction.Down);
                    break;
                case "10":
                    room.Add(Direction.Top, Direction.Left);
                    break;
                case "11":
                    room.Add(Direction.Top, Direction.Right);
                    break;
                case "12":
                    room.Add(Direction.Right, Direction.Down);
                    break;
                case "13":
                    room.Add(Direction.Left, Direction.Down);
                    break;
            }
            rooms.Add(room);
            Console.Error.WriteLine("Room added at {0} {1} with {2} routes", room.x, room.y, room.routes.Count);
        }
    }
}