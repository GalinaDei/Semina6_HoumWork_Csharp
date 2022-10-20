/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int[] ArrayCreate(string message)
{
    Console.WriteLine("Введите числа через пробел");
    string text = Console.ReadLine()??"";
    string[] textArray = text.Split(" ");
  int[]numArray = new int[textArray.Length];
    for (int i = 0; i < textArray.Length; i++)
    {
     numArray[i] = int.Parse(textArray[i]); 
    }  
   return numArray;
}

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)

    if(i<array.Length-1)
    {Console.Write($"{array[i]}, ");}

    else {Console.Write($"{array[i]} -> ");}
}

int NumbersCounter(int [] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            counter=counter+1;
        }
    }
    Console.Write($"{counter}");
    return counter;
}
int [] result=ArrayCreate("Введите числа через запятую");
PrintArray(result);
NumbersCounter(result);

