// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person[] persons = new Person[3]
{
    new Customer{Name="Evrim"},
    new Student{Name="Ali"},
    new Person{Name="Salih"}
};

foreach (var item in persons)
{
    Console.WriteLine(item.Name);
}

class Person2
{

}

class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
}

class Customer : Person  //person ın özelliklerini miras almış olduk. Person2 yi buraya çağıramayız sadece bir nesneyi bir kere miras alabiliriz.
{
    public string City { get; set; }
}

class Student : Person //person ın özelliklerini miras almış olduk.
{
    public string Departmant { get; set; }
}