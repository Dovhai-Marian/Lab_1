public class User
{
    private string _login;
    private string _firstName;
    private string _lastName;
    private int _age;
    private DateTime _dateOfFilling;

    public User(string login, string firstName, string lastName, int age)
    {
        _login = login;
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _dateOfFilling = DateTime.Now;
    }

    public string Login
    {
        get { return _login; }
        set { _login = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public DateTime DateOfFilling
    {
        get { return _dateOfFilling; }
        set { throw new NotSupportedException("Дату заповнення анкети не можна змінити."); }
    }
}
