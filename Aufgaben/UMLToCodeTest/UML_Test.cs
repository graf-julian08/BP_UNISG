namespace UMLToCodeTest
{
    [TestClass]
    public sealed class UML_Test
    {
        [TestMethod]
        public void Test_Manager_Salary5000_Bonus2000()
        {
            // Arrange
            var employee = new UMLToCode.Employee("Julian", 5000);
            var manager = new UMLToCode.Manager("Philipp", employee.GetMonthlySalary(), 2000);

            int expectedResult = 7000;

            // Act
            int managerSalary = employee.GetMonthlySalary() + manager.GetBonus();

            // Assert
            Assert.AreEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void Test_Manager_Salary8000_Bonus1000()
        {
            // Arrange
            var employee = new UMLToCode.Employee("Hans", 8000);
            var manager = new UMLToCode.Manager("Max", employee.GetMonthlySalary(), 1000);
            int expectedSalary = 9000;

            // Act
            int expectedResult = manager.GetSalary();

            // Assert
            Assert.AreEqual(expectedSalary, expectedResult);
        }

        [TestMethod]
        public void Test_ManagerSalary_Greater_EmployeeSalary()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Peter", 5000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Rainer", employee.GetMonthlySalary(), 3000);

            bool expectedResult = true;

            // Act
            int managerSalary = employee.GetMonthlySalary() + manager.GetBonus();
            if (managerSalary > employee.GetMonthlySalary())
            {
                expectedResult = true;
            }
            else
            {
                expectedResult = false;
            }

            // Assert
            Assert.IsTrue(expectedResult);
        }

        [TestMethod]
        public void WrongTest_Manager_Salary6000_Bonus1000()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Marta", 6000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Joel", employee.GetMonthlySalary(), 1000);

            int expectedResult = 5000;

            // Act
            int managerSalary = employee.GetMonthlySalary() + manager.GetBonus();

            // Assert
            Assert.AreNotEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void WrongTest_Manager_Salary8000_Bonus2000()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Timo", 8000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Markus", employee.GetMonthlySalary(), 2000);

            int expectedResult = 11000;

            // Act
            int managerSalary = employee.GetMonthlySalary() + manager.GetBonus();

            // Assert
            Assert.AreNotEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void WrongTest_ManagerSalary_Greater_EmployeeSalary()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Robin", 4000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Michelle", employee.GetMonthlySalary(), -1500);

            bool expectedResult = false;

            // Act
            int managerSalary = employee.GetMonthlySalary() + manager.GetBonus();
            if (managerSalary > employee.GetMonthlySalary())
            {
                expectedResult = true;
            }
            else
            {
                expectedResult = false;
            }

            // Assert
            Assert.IsFalse(expectedResult);
        }
    }
}