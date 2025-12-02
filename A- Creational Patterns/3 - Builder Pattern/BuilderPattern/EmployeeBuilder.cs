namespace BuilderPattern
{
    public class EmployeeBuilder : IEmployeeBuilder
    {
        private readonly Employee _employee;
        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        public EmployeeBuilder SetEmployeeId(int id)
        {
            _employee.Id = id;
            return this;
        }

        public EmployeeBuilder SetEmployeeName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder SetEmployeeAddress(string address)
        {
            _employee.Address = address;
            return this;
        }

        public EmployeeBuilder SetJobDescription(string description)
        {
            _employee.JobDescription = description;
            return this;
        }

        public Employee Build() 
        {
            return _employee;
        }
    }
}
