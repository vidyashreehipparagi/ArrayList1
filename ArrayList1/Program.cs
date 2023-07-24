using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    internal class Program
    {//Create product class and use array list to add product variables in array list
        //Create book class and use array list to add book variables in array list
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            Product product = new Product{code = 1, name = "Vidya", price = 422.51};
            array.Add(product);
            foreach(Product p in array)
            {
                Console.WriteLine($"{p.code},{p.name},{p.price}");
            }

            Book book= new Book() { id=201,name="Indian Geography",aname="Dr.Ranganath",price=245.25};
            array.Add(book);
            foreach(Book b in array)
            {
                Console.WriteLine($"id :{b.id}\nname :{b.name}\nAuthor name :{b.aname}\nPrice :{b.price}");
            }

        }
    }
}
