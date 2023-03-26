int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2; // не путать местами что нужно присвоить какой переменной!
    if(arg3 > result) result = arg3; // не путать местами что нужно присвоить какой переменной!
    return(result);
}

int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};

//array[0] = 12; // !!!!!тут уже не нужно присваивать тип переменной!!!!!! - это присвоение нулевому элементу массива значения 12 (11 изменится на 12)

//Console.WriteLine(array[0]); // вывод нулевого индекса массива на экран

int result = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(result);



