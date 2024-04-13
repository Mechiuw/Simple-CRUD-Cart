namespace digital_cart;

public class Cart
{
    public List<string> Items { get; set; }
    
    public Cart()
    {
        this.Items = new List<string>();
    }

    public string AddObj(string obj)
    {
        this.Items.Add(obj);
        string message = $"{obj} successfully added to cart";
        return message;
    }
    
    public void Find(string obj)
    {
        string find = Items.Find(Items => Items == obj);
        if (find != null)
        {
            string a = $"item's found : {find}";
            Console.WriteLine(a);
        }
    }

    public void LookAll()
    {
        foreach (var all in this.Items)
        {
            Console.WriteLine(all);
        }
    }

    public string Replace(string obj,string newObj)
    {
        int index = this.Items.IndexOf(obj);
        if (index != -1)
        {
            this.Items[index] = newObj;
            string message = $"Done replacing '{obj}' to {newObj}.";
            return message;
        }
        else
        {
            string message = $"Item '{obj}' not found in cart.";
            return message;
        }
    }

    public void Remove(string obj)
    {
        if (this.Items.Contains(obj))
        {
            this.Items.Remove(obj);
            Console.WriteLine($"Removed '{obj}' from cart.");
        }
        else
        {
            Console.WriteLine($"Item '{obj}' not found in cart.");
        }
    }
}