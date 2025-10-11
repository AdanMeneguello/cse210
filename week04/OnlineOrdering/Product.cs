public class Product
{
    private string _name;
    private string _productId;
    private double _price;     // price per unit
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName() => _name;
    public string GetId() => _productId;
}
