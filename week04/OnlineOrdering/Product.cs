using System;


public class Product
{
    // Contains the name, product id, price, and quantity of each product.

    private int _id;
    private decimal _price;

    private int _qty;

    private string _name;

    // The total cost of this product is computed by multiplying the price per unit and the quantity. 
    // (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)


    public Product(int productId, string name, decimal price, int quantity)
    {
        _id = productId;
        _name = name;
        _qty = quantity;
        _price = price;
    }

    public decimal Cost()
    {
        return _price * _qty;
    }

    public string LabelDetail()
    {
        return $"{_qty}: {_id} {_name} ";
    }
}