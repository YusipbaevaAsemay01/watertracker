```csharp
using System;

class WaterTracker
{
    static void Main()
    {
        // Цель по количеству воды за день (например, 2 литра)
        double dailyGoal = 2.0;
        // Переменная для отслеживания выпитой воды
        double totalConsumed = 0.0;

        Console.WriteLine("Добро пожаловать в Водный трекер!");
        Console.WriteLine("Ваша цель — dailyGoal литра воды в день.");

        // Цикл, который будет продолжаться, пока цель не будет достигнута
        while (totalConsumed < dailyGoal)
        
            // Запрос количества воды, которое было выпито
            Console.WriteLine("Введите количество воды (в литрах), которое вы выпили:");
            double consumed = Convert.ToDouble(Console.ReadLine());
            totalConsumed += consumed;  // Добавляем это количество к общему

            // Выводим прогресс
            double remaining = dailyGoal - totalConsumed;
            if (remaining > 0)
            
                Console.WriteLine("Вы выпили {totalConsumed} литров. Осталось выпить {remaining} литров.\n");
            }
            else
            {
                Console.WriteLine("Поздравляю, цель достигнута! Вы выпили достаточно воды.");
            }
        }
    }
}
