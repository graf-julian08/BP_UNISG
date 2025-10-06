namespace UMLToCode
{
    public class Department
    {
        public int loanCosts(Manager manager, Employee employee)
        {
            int loanCosts = manager.getSalary() + employee.getMonthlySalary();
            return loanCosts;
        }
    }
}