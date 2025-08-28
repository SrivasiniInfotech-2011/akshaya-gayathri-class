namespace CSharpAdvanceTraining.Sample;

public class Math
{
    public double GetSine(int angle) => System.Math.Sin(angle);
    public double GetCosine(int angle) => System.Math.Cos(angle);
    public double GetTangent(int angle) => System.Math.Tan(angle);
}

public class Text
{
    public string ReverseString(string text) => new String(text.Reverse().ToArray())!;
    public string AddString(string text1, string text2) => $"{text1} + {text2}";
}