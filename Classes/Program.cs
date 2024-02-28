// See https://aka.ms/new-console-template for more information
using Classes;

Console.WriteLine("Hello, World!");

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();   

Customer customer = new Customer();
customer.Name = "Ahmet";
customer.LastName = "Demir";
customer.ID = 1;
customer.Address = "Bursa/Nilüfer";

Customer customer2 = new Customer();
customer2.Name = "Elif";
customer2.LastName = "Deniz";
customer2.ID = 2;
customer2.Address = "Bursa/Osmangazi";

Console.WriteLine(customer2.Name);