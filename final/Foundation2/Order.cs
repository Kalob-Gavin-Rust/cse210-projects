using System.Collections.Generic;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (var p in _products)
        {
            total += p.GetTotalCost();
        }

        // Shipping rule: $5 USA, $35 international
        double shipping = _customer.LivesInUSA() ? 5 : 35;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Ship To:\n{_customer.GetName()}\n{_customer.GetAddress().ToString()}";
    }
}
