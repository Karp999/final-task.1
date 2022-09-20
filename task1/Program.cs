/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
string[] initialArray = new string[5];
Console.WriteLine();
FillArray(initialArray);
Console.WriteLine();
Console.WriteLine($"Элементы введённого массива: ");
PrintInitialArray(initialArray);
Console.WriteLine();

string[] newArray = new string[initialArray.Length];
NoMoreThanThreeArray(initialArray);
Console.WriteLine("Элементы нового массива, длина которых меньше, либо равна трём символам: ");
PrintNewArray(newArray);
Console.WriteLine();
Console.WriteLine();


void FillArray(string[] initialArray) // метод заполнения первоначального массива
{
    for (int i = 0; i < initialArray.Length; i++) //i-позиция в массиве
    {
        Console.Write($"Введите значение элемента массива {i + 1}: ");
        initialArray[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintInitialArray(string[] initialArray) // метод вывода первоначального массива
{
    for (int i = 0; i < initialArray.Length; i++)
    {
        Console.Write($"  {initialArray[i]}  ");
    }
}

void NoMoreThanThreeArray(string[] initialArray) // метод поиска строк, длина которых меньше, либо равна трём символам
{
    int k = 0; //k-позиция в новом массиве
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            newArray[k] = initialArray[i];
            k++;
        }
    }
}

void PrintNewArray(string[] newArray) // метод вывода нового массива
{
    for (int k = 0; k < newArray.Length; k++)
    {
        Console.Write($"  {newArray[k]}  ");
    }
}



