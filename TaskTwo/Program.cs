System.Console.Write("Ведите число от 1 до 4 : ");

int number = Convert.ToInt32(Console.ReadLine());


switch (number)
{
  case 1:
    System.Console.WriteLine("X > 0, Y > 0");
    break;
  case 2:
    System.Console.WriteLine("X < 0, Y > 0");
    break;
  case 3:
    System.Console.WriteLine("X < 0, Y < 0");
    break;
  case 4:
    System.Console.WriteLine("X > 0, Y < 0");
    break;
  default:
    System.Console.WriteLine("Такой координатной плоскости не существует!!!");
    break;
}