//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Ведите число  ");
int number = int.Parse(Console.ReadLine());
int[] myArray = number.ToString().Select(x => int.Parse(x.ToString())).ToArray();

int DigitsSum(int [] myArray) 
{
      int result = myArray.Sum();
      return result;  
      
}

DigitsSum(myArray);
System.Console.Write($"Сумма элементов массива равна ---> {DigitsSum(myArray)}");
System.Console.WriteLine();




//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponent(int a, int b)
{
int result = 1;
for (int i = 1; i <= b; i++)
{
    result *= a;
   
}
 return result;
}
System.Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите степень:");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Число {a} в степени {b} это --> {Exponent(a, b)}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] myArray2 = new int [8];
void FillArray(int[] myArray2)
{
  for (int i = 0; i < myArray2.Length; i++)
  {
    
        myArray2[i] = new Random().Next(0,50);
    
  }
}
void printArray (int [] myArray2) 
{
    for (int i = 0; i < myArray2.Length; i++)
    {
        System.Console.Write($"{myArray2[i]} ");
    }
    System.Console.WriteLine();
}
FillArray(myArray2);
printArray(myArray2);
