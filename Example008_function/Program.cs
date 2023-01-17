int a1 = 1;
int a2 = 6;
int a3 = 15566;
int b1 = 2;
int b2 = 2;
int b3 = 2;
int c1 = 6;
int c2 = 8;
int c3 = 4;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

System.Console.WriteLine(max);