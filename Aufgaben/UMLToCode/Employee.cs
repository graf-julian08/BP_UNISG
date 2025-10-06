namespace UMLToCode
{
    public class Employee
    {
        public string Name { get; private set; }
        public int monthlySalary { get; private set; }

        public Employee(string name, int monthlySalary)
        {
            Name = name;
            this.monthlySalary = monthlySalary;
        }

        public int getMonthlySalary()
        {
            return monthlySalary;
        }
    }
}