namespace HomeworkWeek4pt1;
class Program
{
    static void Main(string[] args)
    {
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
        int a = 3, b=5;
        int lar = largest( a, b);
        Console.WriteLine($"a = {a}; b={b}\nThe largest number is: "+lar);
        }
    }
}
