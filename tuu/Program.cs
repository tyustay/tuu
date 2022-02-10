﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = from t in teams // определяем каждый объект из teams как t
                                where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                orderby t // упорядочиваем по возрастанию
                                select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
