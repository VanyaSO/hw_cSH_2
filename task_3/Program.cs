// Створіть клас «Закордонний паспорт». Вам необхідно
// зберігати інформацію про номер паспорта, ПІБ власника,
// дату видачі, тощо. Передбачити механізми ініціалізації 
// полів класу. Якщо значення для ініціалізації неправильне, генеруйте виняток. 

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForeignPassport passport = new ForeignPassport();
            try
            {
                passport = new ForeignPassport(0, new FullName("Alex", "Sidorenko", "Petrovich"),
                    new Date(1, 1, 2022));
                Console.WriteLine(passport);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"ArgumentOutOfRangeException: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"ArgumentException: {e.Message}");
            }

        }
    }
}