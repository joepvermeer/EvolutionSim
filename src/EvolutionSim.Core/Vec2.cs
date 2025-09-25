namespace EvolutionSim.Core;

public readonly record struct Vec2(double X, double Y)
{
    public Vec2 Wrap(double width, double height) => new(
        (X % width + width) % width,
        (Y % height + height) % height
    );

    public static Vec2 operator +(Vec2 a, Vec2 b) => new(a.X + b.X, a.Y + b.Y);
    public static Vec2 operator *(Vec2 a, double s) => new(a.X * s, a.Y * s);

    public double Dist2(Vec2 other)
    {
        double dx = X - other.X, dy = Y - other.Y;
        return dx * dx + dy * dy;
    }
}