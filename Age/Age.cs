using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Моля, въведете рожденната си дата: ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Now;

            int age = today.Year - birthDay.Year;

            if (today < birthDay.AddYears(age))
            {
                age--;
            }

            Console.WriteLine("Вие сте на {0} години.",age);
            Console.WriteLine("След 10 години ще бъдете на {0}",age + 10);

        }
    }
}
