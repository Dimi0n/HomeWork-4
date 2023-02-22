//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите элементы массива  ");
int ElementsCount = int.Parse(Console.ReadLine());
int [] myArray = new int [ElementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    System.Console.WriteLine($"Введите элемент массива под индексом {i}  ");
    myArray[i] = int.Parse(Console.ReadLine());
}
System.Console.Write("Сумма элементов массива равна ---> ");
int result = myArray.Sum();
System.Console.WriteLine(result);


//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Вариант_1 
double a = 5.55;
double b = 2;
System.Console.WriteLine(Math.Pow(a,b));

int [] myArray = {2,4,5,6,7,44,54};
Console.WriteLine(myArray[0..3]);


//Вариант_2
System.Console.WriteLine("Число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Степень: ");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine();

for (int i = 1; i <=b; i++)
{
    int res = (a*i);
    if (i==b)
    {
        System.Console.WriteLine(res);
    }
    
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = {55, 25, 13, 4, 7, 6, 27, 89};
Console.WriteLine("Элементы с 0 по 4:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i] + " ");
            }
Console.WriteLine();
Console.WriteLine("Элементы с 5 по 8:");
            for (int i = 5; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
Console.WriteLine();
