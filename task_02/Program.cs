/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5*/

Console.WriteLine("Введите позицию элемента в строке: ");
int row = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите позицию элемента в столбце: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(5,5);
PrintArray(array);
Console.WriteLine();
FindElement(array,row,column);

int[,] GetArray(int size1, int size2)
{
    int[,] res = new int[size1,size2];
    for(int i = 0; i < size1; i++){
        for(int j = 0; j < size2; j++){
            res[i,j] = new Random().Next(100);
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
}
void FindElement(int[,] array, int row, int column){
   if(row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1)) {
    Console.WriteLine($"Ha позиции [{row},{column}] элемента нет. Выход за пределы массива! ");
    } else {
    int res = array[row,column];
    Console.WriteLine($"Ha позиции [{row},{column}] есть элемент {array[row,column]}");
    }
}
    
