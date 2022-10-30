namespace MSTest_Example
{
    public class Vector3
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }

        override public string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }

        public Vector3 Add(Vector3 other)
        {
            return new Vector3
            {
                X = this.X + other.X,
                Y = this.Y + other.Y,
                Z = this.Z + other.Z
            };
        }

        public double Dot(Vector3 other)
        {
            return (this.X * other.X) + (this.Y * other.Y) + (this.Z * other.Z);
        }

        public override bool Equals(object? obj)
        {
            Vector3? other = obj as Vector3;
            if (other == null)
            {
                return false;
            }

            return (this.X == other.X && this.Y == other.Y && this.Z == other.Z);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}