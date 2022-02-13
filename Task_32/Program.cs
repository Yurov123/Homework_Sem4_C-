//  Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

var numbers = new int[8];
numbers[0] = 0;
numbers[1] = 1;
numbers[2] = 0;
numbers[3] = 1;
numbers[5] = 1;
numbers[6] = 1;
numbers[7] = 0;

Console.WriteLine(string.Join(", ", numbers));
 Console.WriteLine();
 
// вариант с рандомом

Console.Write("Enter the size of the array: ");
int[] Mass = new int[int.Parse(Console.ReadLine())];
var random = new Random();
for (int i = 0; i < Mass.Length; i++)
{
    Mass[i] = random.Next(0,2);
    Console.WriteLine( Mass[i]);
}
 Console.WriteLine();

// двумерный массив

int[,] myArr = new int[2, 4]; // Объявляем двумерный массив

Random ran = new Random();

for (int i = 0; i < 2; i++) // Инициализируем данный массив
{
    for (int j = 0; j < 4; j++)
    {
       myArr[i, j] = ran.Next(0, 2);
       Console.Write("{0}\t", myArr[i, j]);
    }
    Console.WriteLine();
}










