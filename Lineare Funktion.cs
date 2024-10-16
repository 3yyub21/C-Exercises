Console.WriteLine("Geben Sie die Komponente von ersten Punkt ein:");
Console.Write("X1 = ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Y1 = ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Geben Sie die Komponente von zweiten Punkt ein:");
Console.Write("X2 = ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Y2 = ");
int Y2 = int.Parse(Console.ReadLine());

static double LineareFunktionM(double a, double b, double c, double d)
{
    double m = (d - b) / (c - a);
    return m;
}

static double LineareFunktionN(double a, double b, double c, double d)
{
    double n = b - (LineareFunktionM(a, b, c, d) * a);
    return n;
}

Console.WriteLine("P1({0};{1}) , P2({2};{3})", X1, Y1, X2, Y2);

if (LineareFunktionN(X1, Y1, X2, Y2) > 0)
{
    Console.WriteLine("Die Funktion lautet: f(x)={0}x+{1}", LineareFunktionM(X1, Y1, X2, Y2), LineareFunktionN(X1, Y1, X2, Y2));
}

else if (LineareFunktionN(X1, Y1, X2, Y2) == 0)
{
    Console.WriteLine("Ungltige Eingabe!");
    Environment.Exit(0);
}

else
{
    Console.WriteLine("Die Funktion lautet: f(x)={0}x{1}", LineareFunktionM(X1, Y1, X2, Y2), LineareFunktionN(X1, Y1, X2, Y2));
}
