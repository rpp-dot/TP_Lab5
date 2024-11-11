using System;

namespace InsuranceAgencyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в страховое агентство!");

            RegisterClient();
        }

        static void RegisterClient()
        {
            Console.WriteLine("Введите имя клиента:");
            string clientName = Console.ReadLine();
            Console.WriteLine($"Клиент {clientName} зарегистрирован!");
        }
    }
}