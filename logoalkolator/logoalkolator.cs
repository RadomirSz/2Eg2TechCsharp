// const string login="";
// const string haslo = "";

// string Plogin = Console.ReadLine();
// string Phaslo = Console.ReadLine();

// if (haslo == Phaslo && login == Plogin)
// {
//     float x = float.Parse(Console.ReadLine());
//     if(trzezwosc());
//     {}
// }



bool trzezwosc()
{ 
    byte proby = 0;
    bool flaga = false;
    Random r = new Random();

    do{
    int a = r.Next(1, 10);
    int b = r.Next(1, 10);
    int c = r.Next(1, 10);

    int los = r.Next(1,5);
    char x;
    switch(los)
        {
            case 1:
                x = '+';
                break;
            case 2:
                x = '-';
                break;
            case 3:
                x = '*';
                break;
            default:
                x = '/';
                break;
        }

    int los2 = r.Next(1,5);
    char y;
    switch(los2)
        {
            case 1:
                y = '+';
                break;
            case 2:
                y = '-';
                break;
            case 3:
                y = '*';
                break;
            default:
                y = '/';
                break;
        }
    
    System.Console.WriteLine($"Podaj wynik tego działania: {a}{x}{b}{y}{c}");
    float wynik = 123;
    float Pwynik = float.Parse(Console.ReadLine());
    if(wynik == Pwynik)
        {
            flaga = true;
            break;
        }
    proby++;
    }
    while(proby != 4);

    if(flaga) return true;
    else System.Console.WriteLine("Jesteś nie trzeźwy!");
    return false;
} // BRAKUJE OBLICZENIA RZECZYWISTEGO WYNIKU
System.Console.WriteLine(trzezwosc());