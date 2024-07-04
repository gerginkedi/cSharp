class Program
{
    static void Main(string[] args)
    {
        Person ömer = new Person();
        ömer.BirthYear = 2005;
        ömer.Blood = Person.BloodGroups.ZeroPositive;
        ömer.Surname = "altuntaş";
        ömer.Name = "ömer";
        ömer.gender = Person.Gender.Male;
        ömer.Month = Person.Months.December;
        ömer.data();
        
    }

    
    
    
    
}