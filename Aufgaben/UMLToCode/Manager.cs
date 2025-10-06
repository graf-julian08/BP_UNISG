namespace UMLToCode
{
    public class Manager : Employee
    {
        public int Bonus { get; private set; }

        // Parametisierter Konstruktor der Basisklasse wird aufgerufen
        public Manager(string name, int monthlySalary, int bonus) : base(name, monthlySalary)
        {
            Bonus = bonus;
        }

        public int GetTotalSalary(int monthlySalary, int bonus)
        {
            int salary = monthlySalary + bonus;
            return salary;
        }
    }
}