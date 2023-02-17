System.Console.WriteLine("Введите число : ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

for (int i = 1; i <= number; i++)
{
  Console.WriteLine(i * i);
}