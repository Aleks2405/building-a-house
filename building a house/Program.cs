﻿using System;
/*Задание 1. Реализовать программу “Строительство дома”
Реализовать:
•	 Классы
■ House (Дом), Basement (Фундамент), Walls (Стены),
Door (Дверь), Window (Окно), Roof (Крыша);
■ Team (Бригада строителей), Worker (Строитель),
TeamLeader (Бригадир).
•	 Интерфейсы
■ IWorker, IPart.
Все части дома должны реализовать интерфейс IPart
(Часть дома), для рабочих и бригадира предоставляется
базовый интерфейс IWorker (Рабочий).
Домашнее задание №6 Домашнее задание №<Номер дз>
Бригада строителей (Team) строит дом (House). Дом
состоит из фундамента (Basement), стен (Wall), окон
(Window), дверей (Door), крыши (Part).
Согласно проекту, в доме должно быть 1 фундамент,
4 стены, 1 дверь, 4 окна и 1 крыша.
Бригада начинает работу, и строители последовательно
“строят” дом, начиная с фундамента. Каждый строитель
не знает заранее, на чём завершился предыдущий этап
строительства, поэтому он “проверяет”, что уже построено и продолжает работу. Если в игру вступает бригадир
(TeamLeader), он не строит, а формирует отчёт, что уже
построено и какая часть работы выполнена.
В конечном итоге на консоль выводится сообщение, что
строительство дома завершено и отображается “рисунок
дома” (вариант отображения выбрать самостоятельно).*/
namespace building_a_house
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] a =
            {
               new  TeamLeader ("Бригадир"),
               new  Walker ("строитель")
            };

            foreach (IWorker item in a)
            {
                Console.WriteLine(item.ToString());  // полиморфизм
            }
        }
    }
}

