using System;

namespace DataAccess
{
    public static class DalFactory
    {
        public static T GetDal<T>()
        {
            Type dalType = null;
            //Here you can any dependency injection framework to create object.
            if (typeof(T) == typeof(IEmployeeRepository))
                dalType = Type.GetType("EmployeeRepository");
            if (dalType != null)
                return (T)Activator.CreateInstance(dalType);
            throw new Exception("DAL type not found");
        }
    }
}