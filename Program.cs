
/*string l = Console.ReadLine();
int s = int.Parse(Console.ReadLine());
int liczba = (int)l[0]-48;
for (int i = 1; i < l.Length; i++)
{
    liczba = liczba *s + (l[i] - 48);
}
Console.WriteLine(liczba);*/

//bin -> dec
/*string b = Console.ReadLine();
int liczba = (int)b[0]-48;
for (int i = 1; i < b.Length; i++) liczba = liczba * 2 + (b[i] - 48);
Console.WriteLine(liczba);
*/
//dec -> bin

int d = int.Parse(Console.ReadLine());
string bin = "";
while (d > 0)
{
    if (d % 2 == 1) bin= "1" + bin;
    else bin = "0" + bin;
    d /= 2;
}
Console.WriteLine(bin);