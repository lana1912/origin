int VFriend1 = 1;
int VFriend2 = 2;
int VDog = 5;
double distance = 10000;
int count = 0;
int Friend = 2;
double time = 0;

while (distance<10)

{
    if (Friend==1)
    {
         time= distance/(VFriend1+VDog);
         Friend = 2;
    }
    else 
    {
         time= distance/(VFriend2+VDog);
         Friend = 1;
    }
 distance=distance-(VFriend1+VFriend2)*time;
 count++;
}
Console.WriteLine(count);