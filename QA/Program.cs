using QA;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите первое число:");
            decimal num1 = decimal.Parse(Console.ReadLine()); // Чтение строки с консоли и преобразование в целое число

            Console.WriteLine("Введите второе число:");
            decimal num2 = decimal.Parse(Console.ReadLine()); // Чтение строки с консоли и преобразование в целое число

            // Пример использования
            BigInteger<decimal> bigInt1 = new BigInteger<decimal>(num1); // Создание объекта BigInteger с первым числом
            BigInteger<decimal> bigInt2 = new BigInteger<decimal>(num2); // Создание объекта BigInteger со вторым числом

            // Добавим проверку на ноль перед умножением
            if (!EqualityComparer<decimal>.Default.Equals(num2, 0)) // Проверка на ноль перед умножением
            {
                BigInteger<decimal> product = bigInt1 * bigInt2; // Выполнение операции умножения
                Console.WriteLine("Product: " + product.Value); // Вывод результата умножения
            }
            else
            {
                Console.WriteLine("Умножение на ноль недопустимо."); // Вывод сообщения об ошибке при умножении на ноль
            }

            // Проверку на ноль перед делением
            if (!EqualityComparer<decimal>.Default.Equals(num2, 0)) // Проверка на ноль перед делением
            {
                BigInteger<decimal> division = bigInt1 / bigInt2; // Выполнение операции деления
                Console.WriteLine("Результат: " + division.Value); // Вывод результата деления
            }
            else
            {
                Console.WriteLine("Деление на ноль недопустимо."); // Вывод сообщения об ошибке при делении на ноль
            }
        }
        catch (Exception ex) // Обработка исключений
        {
            Console.WriteLine("Ошибка: " + ex.Message); // Вывод сообщения об ошибке
        }
    }
}