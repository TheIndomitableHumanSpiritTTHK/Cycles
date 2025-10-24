//Console.WriteLine("Joonistan sulle kolmnurga. Sisesta kolmnurga suurus");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while (i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write("T");
//        j++;
//    }
//    i++;
//}


Console.WriteLine("Tere tulemast modifix parandusautomaati! Kuidas saan aidata");
Console.WriteLine("0 - head aega\n1 - tahan telefoni parandada");
Console.WriteLine("palun tee valik, kirjutades vastav arv: ");
int valik = int.Parse(Console.ReadLine());

while (valik < 0 && valik > 1)
{
    Console.WriteLine("0 - head aega\n1 - tahan telefoni parandada");
    valik = int.Parse(Console.ReadLine());
}

if (valik == 0)
{
    Console.WriteLine("Head aega, tulle teine kord jälle");
}

switch (valik)
{
	default:
		break;
	case 0:
        Console.WriteLine("Head aega, tulle teine kord jälle");
        break;
	case 1:
        Console.WriteLine("Palun sisesta oma telefoni mudel, mida parandada soovid");
        Console.WriteLine("1 - IFöön\n2 - xiaomjau\n3 - nihhuawei\n4 - Scamsung");
        Console.WriteLine("palun tee valik, kirjutades vastav arv: ");
        int telefoniMudel = int.Parse(Console.ReadLine());
        while (telefoniMudel < 1 && telefoniMudel > 4)
        {
            Console.WriteLine("1 - IFöön\n2 - xiaomjau\n3 - nihhuawei\n4 - Scamsung");
            Console.WriteLine("palun tee valik, kirjutades vastav arv: ");
            telefoniMudel = int.Parse(Console.ReadLine());

        }


        switch (telefoniMudel)
        {
            default:
                Console.WriteLine("See telefoni kahjuks ei parandame, sorri");
                break;
            case 1:
                Console.WriteLine("Aitäh, oma iFööni saad tagasi 1 nädala pärast");
                break;
            case 2:
                Console.WriteLine("Aitäh, oma xiaomjau saad tagasi 1 päeva pärast");
                break;
            case 3:
                Console.WriteLine("Aitäh, oma nihhuawei saad maailmalõppu pärast");
                break;
            case 4:
                Console.WriteLine("Aitäh, oma Scamsung saad tagasi 1 päeva pärast");
                break;
        }

        break;
}
