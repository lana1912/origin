//Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые
//нарушают порядок возрастания
//больше среднего арифметического элементов A
//чётные

int [] A = new int [12];

int index = 0;
while (index<12) 
{
    A [index] = new Random().Next(10,100);
    index++;
}
index = 0;
Console.WriteLine();
while (index<12)
{
    Console.WriteLine(A[index]);
    index++;
}

Console.WriteLine();
Console.WriteLine("Второй массив: ");

 index = 1;
int CurrentValue = A[0];
Console.WriteLine(CurrentValue);

while (index<12)
{
    if (CurrentValue<A[index])
   {
     Console.WriteLine(A[index]);
     CurrentValue = A[index];
   }
   index++;
}
Console.WriteLine();
double Aver = A.Average();
Console.WriteLine("Среднее арифметическое: ");
Console.WriteLine(Aver);
Console.WriteLine();
Console.WriteLine("Массив из чисел больше среднего арифметического: ");

index = 0;
while(index<12)
{
    if(Aver<A[index])
    {
      Console.WriteLine(A[index]);
      CurrentValue = A[index];
    }
    index++;
    
}
Console.WriteLine();
Console.WriteLine("Массив из четных чисел:");
index = 0;
while (index<12)
{
    if(A[index]%2==0)
    {
         Console.WriteLine(A[index]);
         CurrentValue = A[index];
    }
    index++;
}
