namespace UMLToCode
{
    public class Employee
    {
        public string Name { get; private set; }
        public int MonthlySalary { get; private set; }

        public Employee(string name, int monthlySalary)
        {
            Name = name;
            MonthlySalary = monthlySalary;
        }

        public int GetMonthlySalary()
        {
            return MonthlySalary;
        }
    }
}