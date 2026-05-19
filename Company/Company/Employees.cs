using System.Globalization;

namespace Company {
    internal class Employees {
        private static int _nextId = 1;
        public string Id { get; private set; }
        public string Name { get; private set; }
        public decimal Salary { get; private set; }

        // Constructors
        public Employees(string name, decimal salary) {
            Id = _nextId++.ToString("D3");
            Name = name;
            Salary = salary;
        }      

        // Methods     
        public void IncreaseSalary(decimal percentage) {
             Salary += Salary * (percentage / 100);
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
