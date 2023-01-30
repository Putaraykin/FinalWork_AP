//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
string[] ArrayInit = new string[5] {"One", "two", "three", "4", "5"};
string[] ArrayFin = new string[ArrayInit.Length];
void GetEditArray(string[] ArrayInit, string[] ArrayFin)
{
    int count = 0;
    for (int i = 0; i < ArrayInit.Length; i++)
    {
    if(ArrayInit[i].Length <= 3)
        {
        ArrayFin[count] = ArrayInit[i];
        count++;
        }
    }
}
void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
GetEditArray(ArrayInit, ArrayFin);
Console.Write("Исходный массив: ");
PrintArray(ArrayInit);
Console.Write("Итоговый массив: ");
PrintArray(ArrayFin);