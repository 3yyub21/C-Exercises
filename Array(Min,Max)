Console.Write("Geben Sie die Länge des Arrays ein: ");
int[] Zahlen = new int[int.Parse(Console.ReadLine())];

for (int i = 0; i < Zahlen.Length; i++)
{
    Console.Write("element - {0} : ", i);
    Zahlen[i] = int.Parse(Console.ReadLine());
}

Console.Write("Zahlen von Array sind: ");

for (int i = 0; i < Zahlen.Length; i++)
{
    Console.Write("{0}" + " ", Zahlen[i]);
}

int Max = Zahlen[0];
int Min = Zahlen[0];

for (int i = 0; i < Zahlen.Length; i++)
{
    Max = Zahlen[i] > Max ? Zahlen[i] : Max;

    Min = Zahlen[i] < Min ? Zahlen[i] : Min;
}

Console.WriteLine();
