int number = 12345;
int i = 1;
int a = 0;
int sum1 = 0;
int sum2 = 0;
while(number!=0)
{
    a = number % 10;
    if(i%2==1)
    {
        sum1 += a;
    }
    else
    {
        sum2 += a;
    }
    i++;
    number = number / 10;  
}
Console.WriteLine(sum1*sum2);