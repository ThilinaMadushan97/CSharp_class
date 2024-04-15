using CSharp_class;

var person1 = new Person
{ 
    LastName = "Madushan" 
};

person1.FirstName = "Thilina";
person1.Salary = 18500;


Console.WriteLine($"{person1.FirstName} {person1.LastName}, Salary is {person1.Salary}");
