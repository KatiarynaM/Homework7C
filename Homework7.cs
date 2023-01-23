//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
/*0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Write("Введите количество строк: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns1 = int.Parse(Console.ReadLine()!);

double [,] array1 = GetArrayDouble (rows1, columns1, -1000, 1000);
PrintArrayD(array1);

//Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли такое число
// в двумерном массиве и возвращает сообщение о том, что оно найдено или же указание, 
//что такого элемента нет.
Console.Write("Введите количество строк: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int num2 = int.Parse(Console.ReadLine()!);

int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);
Console.WriteLine();

if(GetFindElement(array2, num2))
{
    Console.WriteLine($"Элемент {num2} в массиве есть");
}
else
{
    Console.WriteLine($"Элемент {num2} в массиве не существует");
}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.

Console.Write("Введите количество строк: ");
int rows3 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns3 = int.Parse(Console.ReadLine()!);

int[,] array3 = GetArray(rows3, columns3, 0, 10);
PrintArray(array3);
Console.WriteLine();

Console.WriteLine($"Среднее арифметическое по столбцам [{String.Join("  ;  ", GetAverage(array3))}]");


//-----Metods----

int [,] GetArray(int m, int n, int minValue, int maxValue){ //случайный двухмерный массив
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array){//вывод массива
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [,] GetArrayDouble(int m, int n, int minValue, int maxValue){ //случайный двухмерный массив
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = Math.Round (new Random().NextDouble() * new Random().Next(minValue, maxValue + 1), 2);// случайное число с округлением до 2-х знаков после ","
        }
    }
    return result;
}

void PrintArrayD(double[,] array){//вывод массива
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


bool GetFindElement(int[,] array, int a){//есть ли число в массиве
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] == a){
                return true;
            }
        } 
    }
return false;
}

double [] GetAverage(int[,] array){ //среднее по столбцам
    double [] result = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++){
        result[i]=0;
        for(int j = 0; j < array.GetLength(0); j++){
            result[i] += array[j,i];
            }
            result[i] = Math.Round (result[i]/array.GetLength(1),2);
        } 
        return result;
    }
