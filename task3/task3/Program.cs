int givenNumber = 2;
int t = givenNumber;
bool m=false;

while (givenNumber != 2)
{
    if (givenNumber % 2 == 0)
        {
            m = true;
        }
    else
        {
            m = false;
            break;
        }
    givenNumber /= 2;

}
//This part doesn't work
if(givenNumber == 1 || givenNumber==2)
{
    m=true;
}
    Console.WriteLine(m);


