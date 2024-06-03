// Користувач вводить у рядок з клавіатури логічний
// вираз. Наприклад, 3>2 або 7<3. Програма має підрахувати
// результат введеного виразу і видати результат: true або false.
// У рядку можуть бути лише цілі числа і оператори: <, >, <=,
// >=, ==, != . Для обробки помилок введення використовуйте механізм виключень.
    
namespace task_4
{
    internal class Program
    {
        static bool resultExpression(int num1, string logicalOperator, int num2)
        {
            switch (logicalOperator)
            {
                case ">":
                    return num1 > num2;
                case "<":
                    return num1 < num2;
                case ">=":
                    return num1 >= num2;
                case "<=":
                    return num1 <= num2;
                case "==":
                    return num1 == num2;
                case "!=":
                    return num1 != num2;
            }
            return false;
        }
        
        static bool Сalculation(string logicalExpression)
        {
            string[] operators = new string[] {"<=", ">=", "<", ">", "==", "!="};
            string currentOperator = "";
            int lengthOperator = 0;
            int indexOperator = -1;


            string num1 = "";
            string num2 = "";

            if (!string.IsNullOrWhiteSpace(logicalExpression))
            {
                for (int i = 0; i < operators.Length; i++)
                {
                    // проверка есть ли доступный оператор в выражении
                    if (logicalExpression.Contains(operators[i]))
                    {
                        currentOperator = operators[i];
                        lengthOperator = operators[i].Length;
                        indexOperator = logicalExpression.IndexOf(operators[i]);
                    }
                }
                if (currentOperator == "")
                    throw new ArgumentException("Нет подходящего знака для вычесления результата");
                
                if (logicalExpression.Contains("."))
                    throw new ArgumentException("Доступны только целые числа");

                // получаем числа из выражения
                num1 = logicalExpression.Substring(0, indexOperator);
                num2 = logicalExpression.Substring(indexOperator + lengthOperator);
            }
            
            return resultExpression(int.Parse(num1), currentOperator, int.Parse(num2));
        }
        
        static void Main()
        {
            Console.WriteLine("Enter logical expression");
            string logicalExpression = Console.ReadLine();


            try
            {
                Console.WriteLine(Сalculation(logicalExpression));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

