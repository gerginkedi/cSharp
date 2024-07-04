string input;
int a;
int theNumber = 67;
for (a = 2; a>1;  a++)
{
    input = Console.ReadLine();
    
    
    if(input == "exit")
    {
        break;
    }

    else if(input?.GetType() == typeof(string))
    {
        Console.WriteLine("please enter a number");
    }
    else if (input?.GetType() == typeof(int)&& input > theNumber)
    {

    }
}




