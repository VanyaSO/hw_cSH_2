namespace task_3;

public class ForeignPassport
{
    private int _numberPassport;
    private FullName _fullName;
    private Date _dateOfIssue;

    public ForeignPassport()
    {
        _numberPassport = 1;
        _fullName._name = "empty";
        _fullName._lastName = "empty";
        _fullName._surname = "empty";
        _dateOfIssue._day = 1;
        _dateOfIssue._month = 1;
        _dateOfIssue._year = 1;
    }
    public ForeignPassport(int numberPassport, FullName fullName, Date dateOfIssue)
    {
        if (numberPassport < 1)
            throw new ArgumentOutOfRangeException("Номер паспорта не может быть отрицательным или равняться 0");
        _numberPassport = numberPassport;

        if (string.IsNullOrWhiteSpace(fullName._name) || string.IsNullOrWhiteSpace(fullName._lastName) || string.IsNullOrWhiteSpace(fullName._surname))
            throw new ArgumentException("ФИО не может иметь пустых значений");

        _fullName = fullName;
        _dateOfIssue = dateOfIssue;
    }

    public override string ToString()
    {
        return $"Number passport: {_numberPassport} \n" +
               $"Full name: {_fullName._lastName} {_fullName._name} {_fullName._surname} \n" +
               $"Date of issue: {_dateOfIssue._day}.{_dateOfIssue._month}.{_dateOfIssue._year}";
    }
}