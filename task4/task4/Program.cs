int givenNumber = 13;
bool m = false;
for(int i = 2;i<givenNumber;i++)
{
    if(givenNumber%i!=0)
    {
        m = true;
    }
    else
    {
        m = false;
        break;
    }
}
if(m==true)
{
    Console.WriteLine("Prime");
}
else
{
    Console.WriteLine("Composite");
}