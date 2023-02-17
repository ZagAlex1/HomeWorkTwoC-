System.Console.Write("Введите число :");
int[] number = new int[4];

for (int i = 0; i < number.Length; i++)
{
  number[i] = Convert.ToInt32(Console.ReadLine());
}

double result = Math.Sqrt((number[2] - number[0]) * (number[2] - number[0]) +
((number[3] - number[1]) * (number[3] - number[1])));
System.Console.WriteLine(result);