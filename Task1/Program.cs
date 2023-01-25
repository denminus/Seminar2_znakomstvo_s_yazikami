// Console.Write("введите число");
//  int value = int.Parse(Console.ReadLine()!); // ! -тайное знание
// Console.Write("You number: " + value);

Console.Write("введите пятизначное число");
int value = int.Parse(Console.ReadLine()!);
int n1=value/10000;
int n2=value/1000%10;
int n3=value/100%10;
int n4=value/10%10;
int n5=value%10;
if (n1==n5 && n2==n4) {
    Console.WriteLine("ЭТО ЧИСЛО ПОЛИНДРОМ");
}
else {
Console.WriteLine("ЭТО ЧИСЛО НЕ ПОЛИНДРОМ");
}
// Console.WriteLine(n1);
// Console.WriteLine(n2);
// Console.WriteLine(n3);
// Console.WriteLine(n4);
// Console.WriteLine(n5);