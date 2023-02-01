// Celestia Wilkey, 02/01/2023
// Learning Activity 03
public class Fraction
{
    private int _cwNumerator;
    private int _cwDenominator;
 public Fraction()
    {
        _cwNumerator = 1;
        _cwDenominator = 1;
    }

    public Fraction(int cwWhole)
    {
        _cwNumerator = cwWhole;
        _cwDenominator = 1;
    }

    public Fraction(int cwNumerator, int cwDenominator)
    {
        _cwNumerator = cwNumerator;
        _cwDenominator = cwDenominator;
    }

    public string GetFractionString()
    {
        string text = $"{_cwNumerator}/{_cwDenominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_cwNumerator / (double)_cwDenominator;
    }
}