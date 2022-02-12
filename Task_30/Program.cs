//  Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.Clear();
Console.Write("Enter the number of numbers that have cubes of numbers ending in an even digit = ");
int N = int.Parse(Console.ReadLine());
int count = 0;
int i = 2;

Console.WriteLine();
Console.Write("Cubes of numbers ending in an even number: ");
while (count < N)
{   
    if ((i*i*i) % 2 == 0)
    {
        count++;
        Console.Write(i*i*i + " ");
        i++;
    }
    else i++;
}















