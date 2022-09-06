namespace Homework2;
// Question 1
class Program
{
    static void Main(string[] args)
    {
   Console.WriteLine("Please input a letter grade:");
    //get grade from the user
    char grade=Console.ReadLine()[0];
    //switch block
    switch(grade) {
        //check if grade is A
        //if A then print 4
        case 'A': Console.WriteLine("GPA point: 4");
                  break;
        case 'B': Console.WriteLine("GPA point: 3");
                  break;
        //check if grade C then print 2
        case 'C': Console.WriteLine("GPA point: 2");
                  break;
        case 'D': Console. WriteLine("GPA point: 1");
                  break;
        case 'F': Console.WriteLine("GPA point: 0"); 
                  break; 
        //if any other letter other then a,b,c,d,f
        default:  Console.WriteLine("Wrong Letter Grade!");
                  break;
    }
    }
}

