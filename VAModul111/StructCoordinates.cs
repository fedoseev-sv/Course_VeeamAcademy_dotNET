namespace VAModul111
{
    internal struct Coordinates
    {
        public double? PointX { get; init; }
        public double? PointY { get; init; }
        public string? NameSystem { get; init; }

        public override string ToString()
        {
            return
                $"Point X: {this.PointX} \t" +
                $"Point Y: {this.PointY} \t" +
                $"The name system coordinates: {this.NameSystem}";
        }

        public Coordinates(double? pointA, double? pointB, string? nameSystem)
        {
            this.PointX = pointA;
            this.PointY = pointB;
            this.NameSystem = nameSystem;
        }
    }
}
