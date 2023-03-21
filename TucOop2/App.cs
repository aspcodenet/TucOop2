
public class Person
{
    private string realName;
    public string GetRealName()
    {
        return realName;
    }
    public void SetRealName(string v)
    {
        if (string.IsNullOrEmpty(v))
            throw new ArgumentException("För kort namn");
        realName = v;
    }
    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;
        var l = new List<string>();
        l = l.Where(e => e.Contains("a")).ToList();
        l = l.Where(e =>
        {
            var x = e.Contains("a");
            return x;
        }).ToList();
    }
    public int AddressLength => City.Length + StreetAddress.Length + PostalCode.ToString().Length;
    public int AddressLength2 { 
        get { return City.Length + StreetAddress.Length + PostalCode.ToString().Length; } 
    }
    //public int GetAddressLength()
    //{
    //    return City.Length + StreetAddress.Length + PostalCode.ToString().Length;
    //}


    public DateTime BirthDate { get; private set; }

    //    public required int Test { get; init; }



    private string namn;
    public string Namn { 
        get { return namn; } 
        set {
            if (namn.Length < 3) throw new ArgumentException("Ange längre namn tack");
            namn = value.ToUpper();  
        }
        
    }
    public void Relocate(string streetAddress, int postalCode, string city)
    {
        PostalCode = postalCode;
        StreetAddress = streetAddress;
        City = city;
    }
    public int PostalCode { get; private set; }
    public string City { get; private set; }
    public string StreetAddress { get; private set; }
    public void CalculateSalary()
    {
        //Utifrån Birthdate så får mnan en bonus
    }
}

internal class App
{

    internal void Run()
    {
        var person = new Person(new DateTime(1972, 8, 3));
        person.Namn = "Stefan";

        person.Relocate("Testgatan 12", 11122, "Teststad");


        //person.BirthDate = new DateTime(1900, 1, 1);
        //person.BirthDate = new DateTime(1900, 1, 1);


        Console.WriteLine(person.GetRealName());
        person.SetRealName("");
        Console.WriteLine(person.Namn);
        //person.City = "Linköping";
        //person.SetCity("Linköping");
        person.CalculateSalary();
        
    }
}