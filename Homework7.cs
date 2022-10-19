namespace Homework7;
class Program
{
    
        class Customer{
//  Variable to store the customer id  
    private int cus_id;
//  Variable to store the customer name 
    public string cus_name;
//  Variable to store the customer age
    public int cus_age;
 //constructor used to assign id, name and age to the customer when an object is created.
    public Customer(int id, string name, int age) {
    //  Setting the customer id 
     cus_id = id;
    //  Setting the customer name 
     cus_name = name;
    //  setting the customer age 
     cus_age = age;
        }
 // method used to change customer id
    public void ChangeID(int new_id) {
     cus_id = new_id;
        }
  // method used to print customer information(id, name, age) 
    public void PrintCusInfo(){
    //  Printing the values of corresponding customer 
     Console.WriteLine("Customer : "+cus_id+", name : "+cus_name+", age : "+cus_age);
        }
    }
// Main class to run the program
    class HelloWorld {
// Main method
    static void Main() {
    // Intializing the object of customer1 values 
    Customer cust1 = new Customer(110, "Alice", 28);
    // Printing the values of customer1 
    cust1.PrintCusInfo();
    // Intializing the object of customer2 values 
    Customer cust2 = new Customer(111, "Bob", 30);
    // Printing the values of customer2
    cust2.PrintCusInfo();
    // Setting the new id for customer 1 
    cust1.ChangeID(220);
    // Setting the new id for customer 2 
    cust2.ChangeID(221);
    // Printing the values of the customers with changed ids
    cust1.PrintCusInfo();
    cust2.PrintCusInfo();
         }
    }
}
