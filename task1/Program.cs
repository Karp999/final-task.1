/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

/*1.задать массив СТРОК ИМЕННО из 5 элементов -тк не указано,кол-во сама выбрала
2.проверить массив на количество символов через for, 
3.если меньше или 3-вывести через новый массив в for, если больше-нет */

Console.Clear();
string[] initialArray = new string[5];
Console.WriteLine();
FillArray(initialArray);
Console.WriteLine();
Console.Write($"Элементы введённого массива: ");
PrintArray(initialArray);
Console.WriteLine();


void FillArray(string[] initialArray)
{
    for (int i = 0; i < initialArray.Length; i++)
    {
        Console.Write($"Введите значение элемента массива {i+1}: ");
        initialArray[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] initialArray)
{
    for (int i = 0; i < initialArray.Length; i++)
    {
        Console.Write($"  {initialArray[i]}  ");
    }
}


//string[] noMoreThanThreeArray = new string[initialArray.Length];

//FillArray(initialArray, userLength);



/*
NumberOfCharacters(initialArray, noMoreThanThreeArray);
Console.Write("Массив из строк длина которых меньше или равна 3 символам: ");
PrintArray(noMoreThanThreeArray);



void NumberOfCharacters(string[] initialArray, string[] noMoreThanThreeArray)
{
   int count = 0;
   for (int i = 0; i < initialArray.Length; i++)
   {
       if (initialArray[i].Length <= 3)
       {
           noMoreThanThreeArray[count] = initialArray[i];
           count++;
       }
   }
}

*/