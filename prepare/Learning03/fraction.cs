using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        
        _top = 1;

        _bottom = 1;
    }

    public Fraction(int topnumber)
    {
        _top = topnumber;

        _bottom = 1;

    }

    public Fraction(int topnumber, int bottomnumber)
    {
        _top = topnumber;

        _bottom = bottomnumber;

    }

    public void SetTop(int topnumber)
    {
        _top = topnumber;
    }

    public void SetBottom(int bottomnumber)
    {
        if (bottomnumber != 0)
        {
            _bottom = bottomnumber;
        }
        else
        {
            _bottom = 1;
        }
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;

    }

    public double GetDecimalValue()
    {
        return (double) _top/(double)_bottom;
    }

}