// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

ShowThirdNumber(ConvertIntToArray(PutNumber("Введите число : ")));

int PutNumber(string greeting)
{
  Console.Write(greeting);
  int putNumber = Convert.ToInt32(Console.ReadLine());
  return putNumber;
}

char[] ConvertIntToArray(int putNumber)
{
  char[] array = putNumber.ToString().ToCharArray();
  return array;
}

int Count(char[] array)
{
  return array.Length;
}

void ShowThirdNumber(char[] array)
{
  int count = Count(array);
  if (count > 2)
    System.Console.WriteLine($"Третья цифра в числе : {array[2]}");
  else
    System.Console.WriteLine("Третьей цифры в числе нет!!!");
}

