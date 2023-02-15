// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write(ShowSecondNumber(PutNumber("Введите трехзначное число : ")));

int PutNumber(string greeting)
{
  Console.Write(greeting);
  while (true)
  {
    int putNumber = Convert.ToInt32(Console.ReadLine());
    if (putNumber / 10 == 0 || putNumber / 100 == 0 || putNumber / 100 > 9)
      Console.Write("Это не трехзначное число, введите нужное : ");
    else
      return putNumber;
  }
}

string ShowSecondNumber(int putNumber)
{
  char[] array = putNumber.ToString().ToCharArray();
  return ($"Второе число {array[1]}");
}