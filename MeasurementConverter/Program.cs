using System;

namespace Generics_MeasurementConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Measurement<double> celsius = new Measurement<double> { Value = 20, Unit = "°C" };
            Console.WriteLine($"Исходное измерение: {celsius}");

            Measurement<double> fahrenheit = MeasurementConverter.Convert(
                celsius,
                val => val * 1.8 + 32,
                "Фаренгейт"
            );
            Console.WriteLine($"Результат в Фаренгейтах: {fahrenheit}");

            Measurement<string> category = MeasurementConverter.Convert(
                celsius,
                val => val < 0 ? "холодно" : "тепло",
                "текстовая категория"
            );
            Console.WriteLine($"Результат в виде текстовой категории: {category}");

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим конвертации температуры ===");

            while (true)
            {
                try
                {
                    Console.Write("Введите значение температуры в °C (или 'stop' для выхода): ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "stop")
                    {
                        break;
                    }

                    double tempC = double.Parse(input);
                    Measurement<double> userCelsius = new Measurement<double> { Value = tempC, Unit = "°C" };

                    Measurement<double> userFahrenheit = MeasurementConverter.Convert(
                        userCelsius,
                        v => v * 1.8 + 32,
                        "Фаренгейт"
                    );

                    Measurement<string> userCategory = MeasurementConverter.Convert(
                        userCelsius,
                        v => v < 20 ? "холодно" : "тепло",
                        "текстовая категория"
                    );

                    Console.WriteLine($"Конвертация: {userFahrenheit}");
                    Console.WriteLine($"Категория: {userCategory}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}