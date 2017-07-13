namespace LastCrusade
{
    public enum Direction
    {
        Top,
        Left,
        Right,
        Down,
        None
    }

    public class Route
    {
        public Direction In;
        public Direction Out;

        public Route(Direction input, Direction output)
        {
            this.In = input;
            this.Out = output;
        }
    }
}