namespace UMLToCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Philipp", 6000);
            int monthlySalaryEmployee = employee.getMonthlySalary(6000);

            Manager manager = new Manager(2000, "Julian", 6000);
            int monthlySalaryManager = manager.getBonus(6000, 2000);

            Department department = new Department();
            int loanCosts = department.LoanCosts();

            Console.WriteLine($"Angestellter {employee} verdient {monthlySalaryEmployee}Fr. pro Monat. Der Manager verdient {monthlySalaryManager}Fr. pro Monat. Die Lohnkosten in der Abteilung sind {loanCosts}.");
        }
    }
}
