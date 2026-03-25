class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        SetNumerator(1);
        SetDenominator(1);
    }

    public Fraction(int numerator)
    {
        SetNumerator(numerator);
        SetDenominator(1);
    }

    public Fraction (int numerator, int denominator)
    {   
        SetNumerator(numerator);
        SetDenominator(denominator);
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        string fractionString = (_denominator > 1) ? $"{_numerator}/{_denominator}" : $"{_numerator}";
        return fractionString;
    }
    
    public double GetDecimalValue()
    {
        return _numerator / _denominator;
    }

}