// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Solid i harfini uygulamış olduk.(Interface Segregation)
IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var item in workers)
{
    item.Work();
}

IEat[] eats = new IEat[2]
{
    new Worker(),
    new Manager(),
};

foreach (var item in eats)
{
    item.Eat();
}

interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();

}

interface ISalary
{
    void GetSalary();

}

class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}