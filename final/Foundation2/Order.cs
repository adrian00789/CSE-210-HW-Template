using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(List<Product> productList, Customer customer)
    {
        _products = productList;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
            total += product.Price * product.Quantity;
        total += _customer.Address.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in _products)
            label.Append(product.Name + " " + product.Id + "\n");
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return _customer.Name + "\n" + _customer.Address.GetFullAddress();
    }
}