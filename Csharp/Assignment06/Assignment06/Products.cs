//3.Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, 
//    and display the sorted Products.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06
{
    public class Products
    {
        int ProductId;
        string ProductName;
        double price;

        public static void Main(string[] args)
        {
            List<Products> product = new List<Products>
            {

                new Products{ProductId= 111, ProductName="Mouse", price=7000},
                new Products{ProductId= 222, ProductName="Pendrive", price=8000},
                new Products{ProductId= 333, ProductName="Laptop", price=9000},
                new Products{ProductId= 444, ProductName="Bag",    price=6000},
                new Products{ProductId= 555, ProductName="Pen",     price=5000},
                new Products{ProductId= 666, ProductName="pencil",  price=4000},
                new Products{ProductId= 777, ProductName="NoteBook",price=3000},
                new Products{ProductId= 888, ProductName="waterBottles",price=100},
                new Products{ProductId= 999, ProductName=" Mobile",   price=10000},
                new Products{ProductId= 100, ProductName="Box",     price=300}
            };

            var prod = product.OrderBy(Prod => Prod.price).ToList();
            foreach (var items in prod)
            {
                Console.WriteLine("ProductName: {0}\t ProductId: {1}\t Price: {2} ", items.ProductName, items.ProductId, items.price);

            }
            Console.Read();
        }
    }
}