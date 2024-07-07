namespace shestchisel_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100000 до 999999");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 100000 && number <= 999999)

            {
                string numberstring = number.ToString();

                int first3sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    first3sum += numberstring[i] - '0';    //'0' - перетворює символ на цифру//

                }

                int second3sum = 0;
                for (int i = 3; i < 6; i++) ; // здвінули на три позиції числа тому що шукаємо наступні три числа і нам треба перенести значення на 3 
                {
                    second3sum += numberstring[1] - '0';
                }

                if (first3sum == second3sum)
                {
                    Console.WriteLine("Сумма первых трех чисел равна сумме вторых трех чисел");
                }
                else
                {
                    Console.WriteLine("Сумма первых трех чисел НЕ равна сумме вторых трех чисел");
                }
            }
            else
            {

                Console.WriteLine("Помилка: введене число не є шестизначним. Спробуйте ще раз.");
            }

        }
            
        }  
    }
