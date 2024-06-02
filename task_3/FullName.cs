namespace task_3;

public struct FullName
{
    public string _name;
    public string _lastName;
    public string _surname;

    public FullName(string name, string lastName, string surname)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(surname))
            throw new ArgumentException("ФИО не может иметь пустых значений");

        _name = name;
        _lastName = lastName;
        _surname = surname;
    }
}