namespace UMLToCode
{
    public class Department
    {
        public List<Employee> employeeList = new List<Employee>();
        public int LoanCosts(Manager manager)
        {
            int loanCosts = manager.GetSalary();

            foreach (Employee employee in employeeList)
            {
                loanCosts += employee.GetMonthlySalary();
            }

            return loanCosts;
        }
    }
}