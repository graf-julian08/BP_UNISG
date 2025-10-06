namespace UMLToCodeTest
{
    [TestClass]
    public sealed class UML_Test
    {
        [TestMethod]
        public void TestUML1()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Julian", 5000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Philipp", employee.getMonthlySalary(), 2000);

            int expectedResult = 7000;

            // Act
            int managerSalary = employee.getMonthlySalary() + manager.getBonus();

            // Assert
            Assert.AreEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void TestUML2()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Hans", 8000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Max", employee.getMonthlySalary(), 1000);

            int expectedResult = 9000;

            // Act
            int managerSalary = employee.getMonthlySalary() + manager.getBonus();

            // Assert
            Assert.AreEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void TestUML3()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Peter", 5000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Rainer", employee.getMonthlySalary(), 3000);

            int expectedResult = 8000;

            // Act
            int managerSalary = employee.getMonthlySalary() + manager.getBonus();

            // Assert
            Assert.AreEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void TestUMLWrong1()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Marta", 2000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Joel", employee.getMonthlySalary(), 500);

            int expectedResult = 3500;

            // Act
            int managerSalary = employee.getMonthlySalary() + manager.getBonus();

            // Assert
            Assert.AreNotEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void TestUMLWrong2()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Timo", 9000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Markus", employee.getMonthlySalary(), 3500);

            int expectedResult = 11000;

            // Act
            int managerSalary = employee.getMonthlySalary() + manager.getBonus();

            // Assert
            Assert.AreNotEqual(expectedResult, managerSalary);
        }

        [TestMethod]
        public void TestUMLWrong3()
        {
            // Arrange
            UMLToCode.Employee employee = new UMLToCode.Employee("Robin", 4000);
            UMLToCode.Manager manager = new UMLToCode.Manager("Michelle", employee.getMonthlySalary(), 1500);

            int expectedResult = 500;

            // Act
            int managerSalary = employee.getMonthlySalary() + manager.getBonus();

            // Assert
            Assert.AreNotEqual(expectedResult, managerSalary);
        }
    }
}
