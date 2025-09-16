using System;
using System.Collections.Generic;
using System.Linq;
using AnimalShelterBuilderPool.Domain;
using AnimalShelterBuilderPool.Builder;
using AnimalShelterBuilderPool.Pool;

namespace AnimalShelterBuilderPool
{
    /// <summary>
    /// Демо ЛР №3: Builder + Object Pool у темі "Притулок для тварин".
    /// Builder: побудова складного профілю тварини з опційними частинами.
    /// Object Pool: повторне використання транспортних кліток (TransportCrate).
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Animal Shelter — Builder + Object Pool ===\n");

            Console.WriteLine("Оберіть вид тварини для створення профілю (dog|cat|rabbit):");
            Console.Write("> ");
            var choice = (Console.ReadLine() ?? "dog").Trim().ToLowerInvariant();

            IAnimalProfileBuilder builder = choice switch
            {
                "dog" => new DogProfileBuilder(),
                "cat" => new CatProfileBuilder(),
                "rabbit" => new RabbitProfileBuilder(),
                _ => new DogProfileBuilder()
            };

            var director = new IntakeProfileDirector();

            Console.WriteLine("Виберіть сценарій побудови профілю: basic | full");
            Console.Write("> ");
            var scenario = (Console.ReadLine() ?? "basic").Trim().ToLowerInvariant();

            AnimalProfile profile = scenario == "full"
                ? director.BuildFullIntakeProfile(builder, name: "Lucky", ageYears: 2)
                : director.BuildBasicIntakeProfile(builder, name: "Lucky", ageYears: 2);

            Console.WriteLine();
            Console.WriteLine("Збудований профіль:");
            Console.WriteLine(profile.ToMultilineString());

            // ===== Object Pool demo =====
            Console.WriteLine("\nДемонстрація Object Pool — транспортні клітки\n");
            var cratePool = new ObjectPool<TransportCrate>(
                factory: () => new TransportCrate(),
                reset: crate => crate.Reset(),
                maxSize: 3
            );

            // Беремо клітки з пулу для перевезення декількох тварин
            var cratesInUse = new List<TransportCrate>();
            for (int i = 0; i < 4; i++)
            {
                var crate = cratePool.Acquire();
                crate.Label = $"CR-{i+1}";
                crate.Load(profile.Name, profile.Kind);
                cratesInUse.Add(crate);
            }

            Console.WriteLine($"\nКліток в пулі (вільні): {cratePool.AvailableCount}");
            Console.WriteLine($"Кліток у використанні: {cratesInUse.Count}");

            // Повертаємо частину кліток у пул
            foreach (var c in cratesInUse.Take(2))
            {
                c.Unload();
                cratePool.Release(c);
            }

            Console.WriteLine($"\nПісля повернення 2 кліток — вільні: {cratePool.AvailableCount}");

            // Знову забираємо одну клітку (переконаємось, що реюз працює)
            var reused = cratePool.Acquire();
            reused.Label = "CR-REUSE";
            reused.Load("Buddy", profile.Kind);

            Console.WriteLine("\nСтан пулу:");
            Console.WriteLine($"Вільні: {cratePool.AvailableCount}; Усього створено: {cratePool.CreatedCount}");

            Console.WriteLine("\nГотово. Натисніть Enter для виходу...");
            Console.ReadLine();
        }
    }
}
