class Circle:Shape
{
    public float _radius;
    public Circle(float radius, string col)
    {
        _radius = radius;
        _color = col;
    }
    public override float GetArea()
    {
        float area =  (float)Math.PI*_radius*_radius;
        return area;
    }
}