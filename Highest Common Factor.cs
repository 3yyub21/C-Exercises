Console.Write("Geben Sie die erste Zahl ein: ");
int Zahl1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Geben Sie die zweite Zahl ein: ");
int Zahl2 = Convert.ToInt32(Console.ReadLine());
int i, j, Hcf = 1;
j = (Zahl1 < Zahl2) ? Zahl1 : Zahl2;

for (i = 1; i <= j; i++)
{
    if (Zahl1 % i == 0 && Zahl2 % i == 0)
    {
        Hcf = i;
    }
}

Console.Write("{0}", Hcf);
