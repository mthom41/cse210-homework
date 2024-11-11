abstract class Shape
{
    protected string _color;
    public string GetColor()
    {
        return _color;
    }
    protected void SetColor(string col)
    {
        _color = col;
    }
    
    public abstract float GetArea();
}