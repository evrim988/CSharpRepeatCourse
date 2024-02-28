// See https://aka.ms/new-console-template for more information
using Interfaces;

Console.WriteLine("Hello, World!");

//PersonManager personManager = new PersonManager();
//personManager.Add(new Customer { ID = 1, Adress = "Bursa" });

//Student student = new Student()
//{
//    ID = 1,
//    Departmant = "Bilgisayar Mühendisliği"
//};
//personManager.Add(student);

//CustomerManager customerManager = new CustomerManager();
//customerManager.Add(new SqlServerCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal(),
    new MysqlCustomerDal()
};

foreach (var item in customerDals)
{
    item.Add(); 
}

interface IPerson
{
    int ID { get; set;}
}

class Customer : IPerson
{
    public int ID { get; set ; }
    public string Adress { get; set ; }
}

class Student : IPerson
{
    public int ID { get ; set; }
    public string Departmant { get; set ; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.ID);
    }
}