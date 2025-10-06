namespace UMLToCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Philipp", 9000);
            Employee employee2 = new Employee("Markus", 8500);
            Employee employee3 = new Employee("Julian", 7000);
            Manager manager = new Manager("Nazar", 10000, 2000);

            Department department = new Department();
            department.employeeList.Add(employee1);
            department.employeeList.Add(employee2);
            department.employeeList.Add(employee3);

            int loanCosts = department.LoanCosts(manager);

            foreach (var employee in department.employeeList)
            {
                Console.WriteLine($"{employee.Name} ist angestellt und verdient {employee.GetMonthlySalary()}Fr. pro Monat.\n-------------------------------------------------------");
            }
            Console.WriteLine($"{manager.Name} ist ein Manager und verdient {manager.GetSalary()}Fr. pro Monat.\nDer Lohn setzt sich aus dem Gehalt von {manager.MonthlySalary}Fr. und dem Bonus von {manager.GetBonus()}Fr. zusammen.\n-----------------------------------------------------------------------------------\nDie gesamten Lohnkosten in der Abteilung betragen {loanCosts}Fr.");
        }
    }
}