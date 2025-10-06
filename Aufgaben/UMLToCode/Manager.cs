namespace UMLToCode
{
    public class Manager : Employee
    {
        public int Bonus { get; private set; }

        public Manager(string name, int monthlySalary, int bonus) : base(name, monthlySalary)
        {
            Bonus = bonus;
        }

        public int getBonus()
        {
            return Bonus;
        }

        public int getSalary()
        {
            return MonthlySalary + Bonus;
        }
    }
}