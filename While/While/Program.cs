Console.WriteLine("Joonistan sulle kolmnurga. Sisesta kolmnurga suurus");
int kolmnurgaSuurus = int.Parse(Console.ReadLine());

int i = 1;
while (i <= kolmnurgaSuurus)
{
    Console.WriteLine();
    int j = 1;
    while (j <= i)
    {
        Console.Write("T");
        j++;
    }
    i++;
}