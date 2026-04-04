using System.Collections.Generic;
class Order
{
  private Customer _customer;
  private List<Product> _products;

  public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
  public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
  public void AddProduct(Product product)
    {
        _products.Add(product);
    }

  public double Total()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.Total();
        }
        total += _customer.IsLocalCustomer() ? 5 : 35;
        return total;
    }    

  public string ShippingLabel()
    {
        return _customer.ShippingLabel();
    }

  public string PackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += "\n "+product.GetPackingInfo();
        }
        return packingLabel;
    }
}