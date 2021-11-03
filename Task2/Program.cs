int [] A = new int [10];
int index = 0;

while(index<10)
{
  A[index] = new Random().Next(-20,20);
  index++;
}
Console.WriteLine();
Console.WriteLine("Массив из рандомных чисел с отрезка: ");
index = 0;
while (index<10)
{
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив из возрастающих чисел: ");
int CurrentValue = A[0];
Console.WriteLine(CurrentValue);
index = 1;
while (index<10)
{
    if(CurrentValue<A[index])
    {
        Console.WriteLine(A[index]);
        CurrentValue= A[index];
    }
    index++;
}

Console.WriteLine();
Console.WriteLine("Массив, где элементы меньше 8:");
index = 0;
int B = 8;
while(index<10)
{
    if(A[index]<B)
    {
        Console.WriteLine(A[index]);
    }
    index++;
}



