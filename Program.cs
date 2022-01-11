
//  Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// //что делаем?
//1. создать массив
//2. отобрать чётные числа
//3. перенести их в новый массив

// //Задать массив
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 50);
        index++;
    }
}

void PrintArrау(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}

int CountEvenNumbers(int[] oldArrау)
{
    // посчитать сколько чисел чётные
    // создать массив с этими числами
    // пройтись по новому массиву, найти четные числа и добавить их в новый массив
    // return countEvenNumber;
    int index = 0;
    int countEvenNumbers = 0;
    while (index < oldArrау.Length)
    {
        if (oldArrау[index] % 2 == 0) countEvenNumbers++;
        index++;
    }
    return countEvenNumbers;
}
void NewArr(int[] newArray, int[] oldArr)
{
    int index = 0;
    int index2 = 0;
    while (index < oldArr.Length)
    {
        if (oldArr[index] % 2 == 0)
        {
            newArray[index2] = oldArr[index];
            index2++;
        }
        index++;
    }
}
// общее

int[] A = new int[10];
FillArray(A);
PrintArrау(A);
int[] N = new int[CountEvenNumbers(A)];
NewArr(N, A); 
Console.WriteLine();
PrintArrау(N);



