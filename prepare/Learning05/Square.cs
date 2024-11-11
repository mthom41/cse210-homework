class Square:Shape
{
    public float _sideLength;
    public Square(float side, string col)
    {
        _sideLength = side;
        _color = col;
    }
    public override float GetArea()
    {
        float area = _sideLength*_sideLength;
        return area;
    }
}