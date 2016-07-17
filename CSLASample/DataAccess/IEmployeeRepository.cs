namespace DataAccess
{
    public interface IEmployeeRepository
    {
        EmployeeDto GetEmployee(int id);
    }
}