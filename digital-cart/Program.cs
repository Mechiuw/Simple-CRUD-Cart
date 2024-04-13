using digital_cart;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        InsertItems();
    }

    static void InsertItems()
    {
        
        // OPERATING CRUD OPERATION AS "CART"
        // simulating how real world scenario in shopping terms, using simple temporary
        // CRUD operations in C# List.
        
        // commands :
        // .AddObj() to add a string 'object' to cart
        // .Find() to look for a specific 'object' from cart
        // .LookAll() to List all of 'objects' inside the cart
        // .Replace() to update or replace an 'object' inside the cart
        // .Remove() to remove an 'object' inside the cart
        
        // field :
        Cart trolly = new Cart();
        trolly.AddObj("Banana");
        trolly.AddObj("Apple");
        trolly.AddObj("Lego");
        trolly.AddObj("Batteries");
        trolly.AddObj("Drill");
        
        
        trolly.Find("Drill");
        trolly.Replace("Banana","Green Banana");
        
        trolly.Remove("Lego");
        
        trolly.LookAll();
        
        
        
        
        // THIS CODE IS OPEN TO CHANGE IMPROVING THE CODE - - -
    }
}