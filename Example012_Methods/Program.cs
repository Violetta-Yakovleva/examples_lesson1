// Вид 1 - функция ничего не принимает и не возвращает.

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

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; 

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);