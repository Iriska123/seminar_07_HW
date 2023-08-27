/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Sum(array);
Sum2(array);


int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] res = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            res[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sum (int[,] array){
    int sum = 0;
    int j = 0;
    double g = 0;
    Console.Write($"Среднее арифметическое каждого столбца: "); 

    while (j < array.GetLength(1)) {
        for(int i = 0; i < array.GetLength(0); i++){
            sum +=array[i,j]; 
            g = (double)sum/array.GetLength(0);
        }
            //Console.WriteLine($"Сумма столбца = {sum} ");
        Console.Write("{0:f2}; ", g);
        j++;
        sum = 0;
    }
Console.WriteLine();
}

void Sum2(int[,] array) {
 int sum = 0;
 double g = 0;
 Console.Write($"Среднее арифметическое каждого столбца: "); 
    for(int i = 0; i < array.GetLength(1); i++){
        for(int j = 0; j < array.GetLength(0); j++){
            sum += array[j,i];
            g = (double)sum/array.GetLength(0);
            //Console.WriteLine($"Сумма столбца in iter var2 = {sum} ");
        }
    //Console.WriteLine($"Сумма столбца var2 = {sum} ");
    Console.Write("{0:f2}; ", g);
    sum = 0;
    }
}