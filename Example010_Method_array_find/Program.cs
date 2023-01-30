// Принимает на вход массив, находит индекс выбранного числа


//              0  1  2  3  4  5  6  7  8
int[] array = {11,211,31,41,15,41,17,18,19};  // создает массив из чисел, указанных в скобках ФИГУРНЫХ
System.Console.WriteLine("enter number: "); 
int find = Convert.ToInt32(Console.ReadLine()); // считывает введенную переменную, одновременно, конверттируя ее в число 
int index = 0;
while(index < array.Length) // 
{
    if (array[index] == find)
    {
    System.Console.WriteLine(index);
    break;                      // если нужно найти только одну цифру, стаивтся break, чтобы закончить цикл 
    }
index ++;
}