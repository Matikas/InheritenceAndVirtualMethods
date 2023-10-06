namespace InheritenceAndVirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(3.5);
            Console.WriteLine($"Kvadratas turi {square.NumberOfAngles} kampus");
            Console.WriteLine($"Kvadrato krastines ilgis = {square.Size}");


            Entity entity = new Entity();
            Human human = new Human();
            Employee employee = new Employee();

            // entity turi tik Id nes yra tevine klase ir pati is nieko nepaveldi
            entity.Id = 1;

            // human tures savo properciu + tai ka turi Entity
            human.Name = "Marius";
            human.Surname = "Paskevicius";
            human.Birthday = DateTime.Now;
            human.Id = 2;

            // employee tures savo propercius + tai ka turi Human + tai ka turi Entity
            employee.Salary = 1000;                         // Employee
            employee.EmploymentDate = DateTime.Now;         // Employee
            employee.Name = "Vardenis";                     // Human
            employee.Surname = "Pavardenis";                // Human
            employee.Birthday = new DateTime(2000, 01, 01); // Human
            employee.Id = 3;                                // Entity
        }
    }
}