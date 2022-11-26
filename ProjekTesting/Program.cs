// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//List<Rumah> ListRumah = new List<Rumah>();

//for (int j = 0; j < 5; j++)
//{
//    Rumah rumah = new Rumah();
//    rumah.ListLemari = new List<Lemari>();

//    for (int i = 6; i < 9; i++)
//    {
//        Lemari lemari = new Lemari() { Merk = $"Maspion {i + 1}", TanggalBeli = new DateTime(2022, 10, i + 1) };
//        rumah.ListLemari.Add(lemari);
//    }

//    ListRumah.Add(rumah);
//}

//var nums = new List<DateTime> { new DateTime(1, 1, 1), new DateTime(2022, 1, 1), new DateTime(2021, 1, 1) };

//nums.Sort();
//Console.WriteLine(string.Join(",", nums));

//nums.Reverse();
//Console.WriteLine(string.Join(",", nums));

//var words = new List<string> {"falcon", "order", "war",
//        "sky", "ocean", "blue", "cloud", "boy", "by", "raven",
//        "station", "batallion"};

//words.Sort((a, b) => a.Length.CompareTo(b.Length));
//Console.WriteLine(string.Join(",", words));

//words.Sort((a, b) => b.Length.CompareTo(a.Length));
//Console.WriteLine(string.Join(",", words));

var employees = new List<Employee>
{
    new Employee("John Doe", 1230),
    new Employee("Adam Novak", 670),
    new Employee("Robin Brown", 2300),
    new Employee("Rowan Cruise", 990),
    new Employee("Joe Draker", 1190),
    new Employee("Janet Doe", 980),
    new Employee("Lucy Smith", 980),
    new Employee("Thomas Moore", 1400)
};

employees.Sort();

Console.WriteLine(string.Join(Environment.NewLine, employees));


Console.ReadLine();

record Employee(string Name, int Salary) : IComparable<Employee>
{
    public int CompareTo(Employee other)
    {
        return other.Salary.CompareTo(this.Salary);
    }
};


public class Rumah
{
    public string? Pemilik { get; set; }
    public List<Lemari>? ListLemari { get; set; }
}

public class Lemari
{
    public string? Merk { get; set; }
    public DateTime TanggalBeli { get; set; }
}


