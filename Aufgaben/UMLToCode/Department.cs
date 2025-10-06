namespace UMLToCode
{
    public class Department
    {
        public List<Employee> EmployeeList { get; private set; } = new List<Employee>();

        public int LoanCosts(Manager manager)
        {
            int loanCosts = 0;

            foreach (Employee employee in EmployeeList)
            {
                loanCosts += employee.GetMonthlySalary();
            }

            loanCosts += manager.GetSalary();
            return loanCosts;
        }
    }
}