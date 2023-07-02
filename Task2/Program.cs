/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Inputed (string message) 
{   
  Console.Write(message);
  double number = Convert.ToInt32(System.Console.ReadLine());
  return number;
}

double k1 = Inputed("Введите k1: ");
double b1 = Inputed("Введите b1: ");
double k2 = Inputed("Введите k2: ");
double b2 = Inputed("Введите b2: ");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
