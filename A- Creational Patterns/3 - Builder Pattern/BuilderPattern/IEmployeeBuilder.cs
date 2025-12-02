namespace BuilderPattern
{
    public interface IEmployeeBuilder
    {
        EmployeeBuilder SetEmployeeAddress(string address);
        EmployeeBuilder SetEmployeeId(int id);
        EmployeeBuilder SetEmployeeName(string name);
        EmployeeBuilder SetJobDescription(string description);
    }
}