using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double sum = 0;
        foreach (var p in _products)
        {
            sum += p.GetTotalCost();
        }

        // shipping: $5 USA, $35 otherwise
        double shipping = _customer.LivesInUSA() ? 5.0 : 35.0;
        return sum + shipping;
    }

    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        foreach (var p in _products)
        {
            sb.AppendLine($"{p.GetName()} (ID: {p.GetId()})");
        }
        return sb.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetAddressString()}";
    }
}
