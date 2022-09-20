namespace HomeworkWeek4pt2;
class Program
{
    static void Main(string[] args)
    {
        
         int N = 5;
         string str_shape = Console.ReadLine();
         Console.WriteLine($"N is: {N}; shape is {str_shape}");
         Triangle(N, str_shape);
         static void Triangle(int N, string shape){     
            if(shape == "left"){
            for(int row = 0; row<5; row++){
            for(int col = 0; col<5; col++)
        {
        if(row>=col)
            Console.Write('*');
        }
        Console.WriteLine("");
    }
            }  else  {      
         int val = 5;  
         int i, j, k ;  
         for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= val-i; j++)  
            {  
               Console.Write(" ");  
            }  
            for (k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  }
         }     
            }  
         }
        
        }
