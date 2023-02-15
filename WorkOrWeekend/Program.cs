// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
WorkOrWeekend(GreetingMessage("Введите номер дня недели : "));

void WorkOrWeekend(int dayNumber)
{
  if (dayNumber < 6 || dayNumber > 7)
    System.Console.WriteLine("Сегодня не выходной");
  else
    System.Console.WriteLine("Сегодня выходной");

}

int GreetingMessage(string message)
{
  System.Console.Write(message);
  return PutNumber();
}

int PutNumber()
{
  int putNumber = Convert.ToInt32(Console.ReadLine());
  return putNumber;
}