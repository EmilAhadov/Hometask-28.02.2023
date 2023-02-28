int number = 43428312;
int a = 0;
int biggestNumber = 0;
while(number!=0)
{
    a = number % 10;
    if(biggestNumber<=a)
      biggestNumber=a; 
    number = number / 10;
}
Console.WriteLine(biggestNumber);