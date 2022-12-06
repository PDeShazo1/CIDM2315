namespace FinalProject;
class Program
{
public static void Main(string[] args) {
        {
        createAccount();
        }

    static void createAccount()
        {
    Console.WriteLine("----CDIM:2315 Final Project: Preston DeShazo-----\n ------Welcome to Buff Kitchen-------");
        string username = "alice";
        string password = "123";
    Console.WriteLine("Please input username");
        string input_username = Console.ReadLine();
    Console.WriteLine("Please input password");
        string input_password = Console.ReadLine();
     if((username==input_username) && (password==input_password)){
    Console.WriteLine("Log in successfully!");
    Console.WriteLine("");
    Console.WriteLine("** Hello Chashier Alice **");
        Options();
 }
    else{
        Console.WriteLine("Please check you username and password! \n");
        
        createAccount();
 }
    static void Options(){
    {
    string entree,drink,side;
    double price_entree,price_drink,price_side;
    int entree_Choice,drink_choice,side_choice;

    Console.WriteLine("**************************");
    Console.WriteLine("Please Select:");
    Console.WriteLine("1) Start New Order");
    Console.WriteLine("2) Check Submitted Orders");
    Console.WriteLine("3) Remove Finished Orders");
    Console.WriteLine("4) Logout System");
    Console.WriteLine("**************************");
    Console.Write("\r\nSelect an option: ");

    string choice = Console.ReadLine();
        if(choice=="1")
        {
    Console.WriteLine("-->Customer Name: ");
        string customer_Name=Console.ReadLine();
    Console.WriteLine("-->Select Entree");
    Console.WriteLine("0) 0 - Food: Chicken Sandwich Price: 5.99");
    Console.WriteLine("1) 1 - Food: Chicken Nuggets Price: 8.99");
    Console.WriteLine("2) 2 - Food: Chicken Strips Price: 9.99");
    Console.WriteLine("3) 3 - Food: Beef Burger Price: 6.99");

    entree_Choice = Convert.ToInt32(Console.ReadLine());
        if(entree_Choice==0) {
            entree="Chicken Sandwich";
            price_entree = 5.99;
}
    else if(entree_Choice==1){
        entree="Chicken Nuggets";
        price_entree = 8.99;
    
}
    else if(entree_Choice==2){
        entree="Chicken Strips";
        price_entree = 9.99;
}
    else{
        entree="Beef Burger";
        price_entree = 6.99;
}
    Console.WriteLine("-->Select Drink");
    Console.WriteLine("0) 0 - Food: Iced Tea Price: 2.99");
    Console.WriteLine("1) 1 - Food: Soda Price: 1.99");
    Console.WriteLine("2) 2 - Food: Lemonade Price: 2.99");
    Console.WriteLine("3) 3 - Food: Coffee Price: 3.99");

    drink_choice = Convert.ToInt32(Console.ReadLine());
        if(drink_choice==0) {
            drink="Iced Tea";
            price_drink = 2.99;
}
    else if(drink_choice==1){
        drink="Sodas";
        price_drink = 1.99;
    
}
    else if(drink_choice==2){
        drink="Lemonade";
        price_drink =2.99;
}
    else{
        drink="Coffee";
        price_drink = 3.99;
}

    Console.WriteLine("-->Select Side");
    Console.WriteLine("0) 0 - Food: Potato Fries Price: 3.99");
    Console.WriteLine("1) 1 - Food: Salad Price: 4.99");
    Console.WriteLine("2) 2 - Food: Fruit Cup Price: 9.99");
    Console.WriteLine("3) 3 - Food: Potato Chips Price: 2.99");

    side_choice = Convert.ToInt32(Console.ReadLine());
        if(side_choice==0) {
            side="Potato Fries";
            price_side = 3.99;
}
        else if(side_choice==1){
            side="Salad";
            price_side = 4.99;
    
}
        else if(side_choice==2){
            side="Fruit Cup";
            price_side =9.99;
}
        else{
            side="Potato Chips";
            price_side = 2.99;
}

    Console.WriteLine("-----Order Summary-----");
    Console.WriteLine("Food: {0}\t Price: {1}",entree ,price_entree);
    Console.WriteLine("Food: {0}\t Price: {1}",drink ,price_drink);
    Console.WriteLine("Food: {0}\t Price: {1}",side ,price_side);
        double total = price_entree+price_drink+price_side;   
    Console.WriteLine("----- Total: ${0} ------",total);
     Options();
        }
    else if(choice == "2"){
        Console.WriteLine("\nOrders");
         Dictionary<string, double> dict_orders = new Dictionary<string, double>();
        dict_orders.Add("Bob", 12.97);
        dict_orders.Add("John", 16.97);
        dict_orders.Add("Chris", 15.97);
        
        int orders_index = 0;
        foreach(var item in dict_orders){
            Console.WriteLine($"{orders_index} - {item.Key} - {item.Value}\n");
            orders_index++;
        }
        Options();
        
    }
    else if(choice == "3"){
        Console.WriteLine("\nOrders");
         Dictionary<string, double> dict_order = new Dictionary<string, double>();
        dict_order.Add("Bob", 12.97);
        dict_order.Add("John", 17.97);
        dict_order.Add("Chris", 15.97);
        
        int order_index = 0;
        foreach(var item in dict_order){
            Console.WriteLine($"{order_index} - {item.Key} - {item.Value}\n");
            order_index++;
        }
        Console.WriteLine("-->Select order: ");
        int selected_entree_index = Convert.ToInt16(Console.ReadLine());
        // select a food item and print it name/price
        string entree_name = dict_order.ElementAt(selected_entree_index).Key;
        double entree_price = dict_order.ElementAt(selected_entree_index).Value;
        Console.WriteLine($"Selected order: {entree_name} - {entree_price}");
        
        // seelct an entree to remove
        Console.WriteLine("-->Select Order to remove: ");
        int removed_entree_index = Convert.ToInt16(Console.ReadLine());
        string selected_item_key = dict_order.ElementAt(removed_entree_index).Key;
        dict_order.Remove(selected_item_key);

        // reset item index and print current dict_entree. We can see the selected item is removed
        order_index = 0;
        foreach(var item in dict_order){
            Console.WriteLine($"{order_index} - {item.Key} - {item.Value}");
            order_index++;
        }
        Options();

        }
        else if(choice == "4"){
            Console.WriteLine("-->Logout System");
        }
        else{
            Console.WriteLine("Wrong option. Try again");
                Options();
        }
    }
}
        }
    }
}
