namespace HomeworkWeek5Q1;
class Program
{
    static void Main(string[] args)
    {
    // QUESTION 1
    // function named largest that takes 2 Integers a and b
    // and return largest one
        static int largest(int a, int b){  
        if(a>b){
        return a;
    }
        else if(b>a){
        return b;
    }
        else{
        return -1;
    }
        }
        {
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int lar = largest( a, b);
        Console.WriteLine($"a = {a}; b={b}\nThe largest number is: "+lar);
        }



        //QUESTION 2
        //get 4 integers as inputs from the keyboard
        //and returns the largest one
        static int largest(int a, int b){  
        if(a>b){
        return a;
        }
        else if(b>a){
        return b;
        }
        else{
        return -1;
        }
        }
        {
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        
        static int largest4(int a, int b, int c, int d){
            int max1 = largest(a,b);
            int max2 = largest(c,d);
            int max = largest(max1, max2);
            return max;
        }
        {
            int c = Convert.ToInt16(Console.ReadLine());
            int d = Convert.ToInt16(Console.ReadLine());
            int max = largest4(a, b, c, d);
            Console.WriteLine($"a = {a}; b={b}; c = {c}; d={d}\nThe largest number is: "+max);
        }

    //QUESTION 3
    createAccount();
    Console.ReadKey(true);
    }
        public static bool checkAge(int birth_year)
    {

        int age=2022-birth_year;

    if(age>=18)
        return true;

    else
        return false;
    }
    public static void createAccount()
    {

     String userName,password,retypedPassword;

     int birthYear;

     Console.WriteLine("Enter Your Username:");
     userName=Console.ReadLine();

    Console.WriteLine("Enter Your Password:");
     password=Console.ReadLine();

     Console.WriteLine("Enter Your Password Again:");
     retypedPassword=Console.ReadLine();

     Console.WriteLine("Enter Your Birthyear:");

     birthYear=Convert.ToInt32(Console.ReadLine());
        if(checkAge(birthYear))
    {
        if(password==retypedPassword)
     Console.WriteLine("Account is created successfully");

        else
    Console.WriteLine("Wrong password"); 
}
        else
    Console.WriteLine("Could not create an account.");
    }
}
}