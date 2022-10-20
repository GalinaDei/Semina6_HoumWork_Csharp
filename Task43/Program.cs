/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

В точке пересечения прямых y1=y2, x1=x2,
значит, 
k1 * x + b1 = k2 * x + b2;
k1 * x - k2 * x =  b2 - b1;
х(k1 - k2) = b2 -b1;
x = (b2 - b1)/(k1 - k2)
*/
List<int> list = new List<int>();
List<int> CreateList(List<int> list)
{
   for (int i = 0; i < 4; i++)
    {
       Console.WriteLine("Введите число");
       list.Add(int.Parse(Console.ReadLine()));
    }
    return list;
} 

void FindCoordinates(List<int> list)
{
    if(list[1]!=list[3])
 {double b1 = list[0];
 Console.Write($"b1 = {b1}, ");

 double k1 = list[1];
 Console.Write($"k1 = {k1}, ");

 double b2 = list[2];
 Console.Write($"b2 = {b2}, ");

 double k2 = list[3];
 Console.Write($"k2 = {k2} -> ");
 
    double pointX = (b2 - b1)/(k1 - k2);
    double pointY= k1*pointX + b1;
    Console.Write($"({pointX}; ");
    Console.Write($"{pointY})");
 }
 else {Console.WriteLine("Введите не одинаковые числа числа");}
}
FindCoordinates(CreateList(list));

