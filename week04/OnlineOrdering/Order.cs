using System;
using System.Net.Http.Headers;

public class Order
{

    private List<Product> _products = new List<Product>();

    private Customer _customer;


    
    public Order(Customer customer)
    {
        _customer = customer;

    }

    public void AddOrderItem(Product item)
    {
        _products.Add(item);
    }

    public void PrintPackingLabel()
    {
        foreach (Product item in _products)
        {
            Console.WriteLine(item.LabelDetail());
        }
    }

    public void PrintShippingLabel()
    {

        Console.WriteLine(_customer.CustomerName());
        Console.WriteLine(_customer.GetAddress());
    }

    public void DisplayTotal()
    {

        decimal subTotal = 0m;
        foreach (Product item in _products)
        {
            subTotal += item.Cost();
        }

        decimal shipping = _customer.isInUSA() ? 5.00m: 35.00m;




        
        decimal total =  subTotal + shipping;

        Console.WriteLine($"Sub Total: ${subTotal}");
        Console.WriteLine($"Shipping : ${shipping}");
        Console.WriteLine($"Total    : ${total}");
    }

    


}