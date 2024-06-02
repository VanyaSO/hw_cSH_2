namespace task_3;

public struct Date
{
    public byte _day;
    public byte _month;
    public int _year;
    
    public Date(byte day, byte month, int year)
    {
        if (day < 1 || month < 1 || year < 1)
            throw new ArgumentOutOfRangeException("Дата не может быть отрицательной или равняться 0");

        _day = day;
        _month = month;
        _year = year;
    }

}