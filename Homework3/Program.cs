Console.WriteLine("Задача 29 ");
Console.WriteLine(".......................................................... ");


int [] num = new int[8];
Console.Write("[");

for (int i = 0; i < num.Length; i++)
 {
    num [i] = new Random().Next(1, 50);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return num[a];
}
