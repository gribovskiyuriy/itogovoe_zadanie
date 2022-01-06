

// //что делаем?

// //Задать массив
int[] A = new int[100];

    int index = 0;
    while (index < 10)
    {
       A[index] = new Random().Next(-50,50);
        index++;
    }

    index = 0;
    //Заполняем массив
        while (index < 10)
    {
       Console.WriteLine(A[index]);
        index++;
    }
string valueNumber (int i)
{
    string res = string.Empty;
    if (i % 2 == 0) {res = $"Чётное";}
    else 
    return res;
}
string res = valueNumber(13);
Console.WriteLine($"{res}");
