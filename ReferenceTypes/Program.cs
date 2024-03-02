// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//değer tipler
int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 100;

Console.WriteLine("Sayı 1: "+ sayi1); //20 yazar.


//referans tipler
int[] sayilar1 = new int[] { 1, 2, 3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 =  sayilar2;
sayilar2[0] = 1000;

Console.WriteLine("Sayılar1[0] = " + sayilar1[0]);


Person person = new Person();
Person person2 = new Person();

person.Name = "Evrim";
person2 = person;

person.Name = "Ali";

Console.WriteLine(person2.Name);

Customer modelCustomer = new Customer();
modelCustomer.Name = "evrim";
Employee employee = new Employee();


Person person3 = modelCustomer; 
Console.WriteLine(person3.Name);

class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
}

class Customer : Person
{
    public string CreditCardNumber {  get; set; }
}

class Employee : Person
{
    public int EmployeeNumber { get; set; }
}