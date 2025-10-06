namespace UMLToCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Philipp", 9000);

            Manager manager = new Manager("Julian", employee.getMonthlySalary(), 2000);

            Department department = new Department();
            int loanCosts = department.loanCosts(manager, employee);

            Console.WriteLine($"{employee.Name} verdient {employee.getMonthlySalary()}Fr. pro Monat. Der Manager verdient {manager.getSalary()}Fr. pro Monat, das ist {manager.getBonus()}Fr. mehr als der Angestellte. Die gesamten Lohnkosten in der Abteilung betragen {loanCosts}Fr.");
        }
    }
}