public class Product {
    public string Title;
    public int Quantity;
    public double Price;

    public Product(string title, int quantity, double price) {
        Title = title;
        Quantity = quantity;
        Price = price;
    }

    public void Restock(int amount) {
        if (amount <= 0) {
            return;
        }
        Quantity += amount;
    }

    public void Sell(int amount)
    {
        if (amount <= 0 || amount > Quantity)
        {
            return;
        }
        Quantity -= amount;
    }
    
    public double GetTotalValue() {
        return Quantity * Price;
    }
}