﻿using System;

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
        static void CalculatePremium()
        {
            Console.WriteLine("Введите стоимоть имущества:");
            decimal value = decimal.Parse(Console.ReadLine());

            decimal premium = value*0.1;
            Console.WriteLine($"Стоимость премии: ${premium}");
        }
        static void CreatePolicy(decimal value)
        {
            Console.WriteLine($"Полис на сумму {value} создан.");
        }
    }
}