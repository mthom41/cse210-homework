class Rectangle:Shape
{
    public float _side1;
    public float _side2;
    public Rectangle(float side1, float side2, string col)
    {
        _side1 = side1;
        _side2 = side2; 
        _color = col;
    }
    public override float GetArea()
    {
        float area = _side1*_side2;
        return area;
    }
}