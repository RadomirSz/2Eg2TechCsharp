
/*
7.Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
i lecąc z jednakową prędkością przybywają w tym samym czasie. 
Napisz program, który obliczy jaka jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?
*/

/*int w1 = 30;
int w2 = 40;
int odl = 50;

for (int i = 1; i <= odl; i++)
{
    if (w1 * w1 + i * i == w2 * w2 + (odl - i) * (odl - i))
    {
        if (i > odl / 2) Console.WriteLine(i);
        else Console.WriteLine(odl - i);
    }
    
}*/



/*1. Napisz program, który pomnoży dwie macierze losowych liczb. 
Niech user podający wymiary macierzy zadba o odpowiednie wymiary,
tak aby mnożenie było możliwe. Macierze wypełnij losowymi liczbami.*/
using System.Diagnostics.CodeAnalysis;

Random r = new Random();
int a = int.Parse(Console.ReadLine());

int[,] T1 = new int[a,a];
int[,] T2 = new int[a,a];
int[,] Tw = new int[a,a];

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        T1[i, j] = r.Next(0, 10);
    }
}

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        T2[i, j] = r.Next(0, 10);
    }
}

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a;j++)
    {
        int suma = 0;
        byte l = 0;
        for (int x = 0; x < a; x++)
        {
            suma += T1[x, l] * T2[l, x];
            l++;
        }
        Tw[i,j] = suma;
    }
}
foreach (var i in T1) 
    Console.WriteLine(i);


foreach (var i in T2) Console.WriteLine(i);
foreach (var i in Tw) Console.WriteLine(i);

//duj hupa 