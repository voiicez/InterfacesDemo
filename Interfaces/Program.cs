
SqlServerDatabase sqlDb = new SqlServerDatabase();
sqlDb.Create();
sqlDb.Delete();

IPerson person1 = new Customer()
{
    CartNo = "1234",
    FirstName = "Behlül",
    LastName = "Şahin",
    Id = 1
};
person1=new Student()
{
    Id = 2,
    Department = "İstatistik",
    LastName = "Şahin",
    FirstName = "Acar"

};

Console.WriteLine(person1.Id+"\n"+person1.FirstName+"\n"+person1.LastName);

interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get ; set ; }
    public string FirstName { get ; set ; }
    public string LastName { get ; set; }
    public string CartNo { get; set; }
}

class Student : IPerson
{
    public int Id { get ; set ; }
    public string FirstName { get ; set ; }
    public string LastName { get ; set ; }
    public string Department { get; set; }
}

interface IDatabase
{
    void Create();
    void Read();
    void Update();
    void Delete();
}

class SqlServerDatabase : IDatabase
{
    public void Create()
    {
        Console.WriteLine("Created SQL");
    }

    public void Delete()
    {
        Console.WriteLine("Deleted SQL");
    }

    public void Read()
    {
        Console.WriteLine("Read SQL");
    }

    public void Update()
    {
        Console.WriteLine("Update SQL");
    }
}