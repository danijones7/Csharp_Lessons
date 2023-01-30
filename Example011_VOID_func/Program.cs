void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);   // наполняет массив рандомными числами. VOID функция, которая не возвращает какой-то результат, просто работает 
    index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;         // выводит на экран получившийся массив 
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // сделано для того, чтобы если заданного числа нет в массиве , возвращался результат -1

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index ++;
    }
    return position;

}

int[] array = new int [10];     // определили, что нам нужен массив из 10 элементов

FillArray(array);   // заполнили массив 
array[4] = 4;
array[6] = 4;   // чтобы в рандомный набор цифир вписать нужную нам 

PrintArray(array);   //  выврдим созданный массив 
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);