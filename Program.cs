using System;
using System.Text.RegularExpressions;

namespace ConsoleApp213
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int minUpper = 1;
            int minLower = 1;
            int minLength = 8;
            int maxLength = 12;
            string allowedSpecials = "@#/.!')";

            Console.WriteLine("Введите пароль. Пароль должен содержать большие и маленькие буквы, цифры и специальный символ.");
            string enteredPassword = Console.ReadLine();

            char[] characters = enteredPassword.ToCharArray();

            int upper = 0;
            int lower = 0;
            int character = 0;
            int number = 0;
            int length = enteredPassword.Length;
            int illegalCharacters = 0;

            foreach (char enteredCharacters in characters)
            {
                if (char.IsUpper(enteredCharacters))
                {
                    upper = upper + 1;
                }
                else if (char.IsLower(enteredCharacters))
                {
                    lower = lower + 1;
                }
                else if (char.IsNumber(enteredCharacters))
                {
                    number = number + 1;
                }
                else if (allowedSpecials.Contains(enteredCharacters.ToString()))
                {
                    character = character + 1;
                }
                else
                {
                    illegalCharacters = illegalCharacters + 1;
                }

            }

            if (upper < minUpper || lower < minLower || length < minLength || length > maxLength || illegalCharacters >= 1)
            {
                Console.WriteLine("Пароль не соответствует требованиями");
            }
            else
            {
                Console.WriteLine(enteredPassword);
            }

            //2
            Console.WriteLine("Введите номер телефона. Учтите, что первым числом идёт код страны.");
            string phone = Console.ReadLine();
            string phone_pattern = @"(\+7|8|\b)[\(\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[)\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)";
            if (Regex.IsMatch(phone, phone_pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Телефон правильный.");
            }
            else
            {
                Console.WriteLine("Телефон неправильный");
            }

            //3 
            Console.WriteLine("Введите почту");
            string email = Console.ReadLine();
            string email_pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(email, email_pattern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("Почта верна");
            }
            else
            {
                Console.WriteLine("Почта неверна");
            }

            //4
            Console.WriteLine("Введите URL-адрес");
            string url = Console.ReadLine();

            string url_patern = @"@^(https?|ftp)://[^\s/$.?#].[^\s]*$@iS";
            if (Regex.IsMatch(url, url_patern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("URL-адрес верный");
            }
            else
            {
                Console.WriteLine("URL-адрес неверный");
            }

        //5
        Console.WriteLine("Напишите ip-адрес");
            string ip = Console.ReadLine();

            string ip_patern = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
            if (Regex.IsMatch(ip, ip_patern, RegexOptions.IgnoreCase))
            {
                Console.WriteLine("ip-адрес верный");
            }
            else
            {
                Console.WriteLine("ip-адрес неверный");
            }
        }
    }
}
