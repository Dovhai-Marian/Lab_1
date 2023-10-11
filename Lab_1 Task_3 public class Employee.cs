public class Employee
{
    private string _lastName;
    private string _firstName;
    private string _position;
    private int _yearsOfExperience;

    public Employee(string lastName, string firstName)
    {
        _lastName = lastName;
        _firstName = firstName;
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string Position
    {
        get { return _position; }
        set { _position = value; }
    }

    public int YearsOfExperience
    {
        get { return _yearsOfExperience; }
        set { _yearsOfExperience = value; }
    }

    public double CalculateSalary()
    {
        double salary = 0;
        switch (_position)
        {
            case "Інженер":
                salary = 10000;
                break;
            case "Програміст":
                salary = 15000;
                break;
            case "Менеджер":
                salary = 20000;
                break;
        }

        if (_yearsOfExperience > 5)
        {
            salary *= 1.1;
        }

        return salary;
    }

    public double CalculateTax()
    {
        return CalculateSalary() * 0.15;
    }
}
