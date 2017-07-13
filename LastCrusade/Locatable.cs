namespace LastCrusade
{
    public class Locatable
    {
        public int x;
        public int y;

        public Locatable(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Locatable GetDirectionCoordinate(Direction? dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    return new Locatable(this.x, this.y + 1);
                case Direction.Left:
                    return new Locatable(this.x - 1, this.y);
                case Direction.Right:
                    return new Locatable(this.x + 1, this.y);
            }
            return this;//Idk why i do dis
        }

        public bool Equals(Locatable loc)
        {
            return x == loc.x && y == loc.y;
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}