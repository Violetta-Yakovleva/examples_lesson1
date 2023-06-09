﻿// Вид 1 - функция ничего не принимает и не возвращает.

// void Method()
// {
//     Console.WriteLine("Автор ...");
// }

// //Как вызываются такие методы?

// Method(); //указывается название метода (с большой буквы) и обязательно скобки, без скобок будет ошибка


// Вид 2 - функция принимает аргументы, но ничего не возвращает.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");


// void Method2(string msg, int count)
// {
//     int i =  0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2(msg: "Текст", count: 4); //именованные аргументы - ставим двоеточие и пишем тект, который хотим передать, ставим двоеточие и пишем сколько раз указать


// Вид 3 - мтод ничего не получает, но что-то возвращает.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// Вид 4 - метод что-то принимает и что-то возвращает.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; 

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// цикл FOR

// string Method4(int count, string text)
// {
//     string result = String.Empty; 
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//       return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// Задача 1.Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"   
//             012345
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty; 
//     int lenght = text.Length;
//     for(int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) 
//         result = result + $"{newValue}";
//         else 
//         result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'C', 'c');
// Console.WriteLine(newText);
// Console.WriteLine();


// Задача на сортировку методов выбора (метод минимакси).

int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

