using AnimalShelterStructural.Domain;
using AnimalShelterStructural.Composite;

namespace AnimalShelterStructural
{
    /// <summary>
    /// ЛР№5: Composite + Flyweight на темі "Притулок для тварин".
    /// Composite: ієрархія зон/вольєрів/тварин із груповими операціями.
    /// Flyweight: розділення "інваріантних" даних виду (розмір, базові витрати) та "змінних" даних конкретної тварини.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Animal Shelter — Composite + Flyweight ===\n");

            // ---- Flyweight: кэшування спільного стану виду/категорії ----
            var factory = new AnimalTypeFactory();
            var dogLarge = factory.Get("Dog", size: "Large", baseCare: 1500m, diet: "Сухий корм XL");
            var dogSmall = factory.Get("Dog", size: "Small", baseCare: 900m,  diet: "Сухий корм S");
            var catType  = factory.Get("Cat", size: "Standard", baseCare: 700m, diet: "Сухий + паштет");
            var rabbit   = factory.Get("Rabbit", size: "Dwarf", baseCare: 450m,  diet: "Сіно + гранули");

            // ---- Composite: дерево притулку ----
            var shelter = new EnclosureGroup("Shelter");
            var zoneA   = new EnclosureGroup("Zone A");
            var zoneB   = new EnclosureGroup("Zone B");
            var penA1   = new EnclosureGroup("Pen A1");
            var penA2   = new EnclosureGroup("Pen A2");
            var penB1   = new EnclosureGroup("Pen B1");

            // Листя (Animals) використовують Flyweight (AnimalType) + власний контекст (ім'я, вік, примітки).
            var a1 = new AnimalLeaf(new AnimalContext("Rex",    4, "Добрий"), dogLarge);
            var a2 = new AnimalLeaf(new AnimalContext("Mila",   2, "Активна"), dogSmall);
            var a3 = new AnimalLeaf(new AnimalContext("Barsik", 3, "Полюбляє іграшки"), catType);
            var a4 = new AnimalLeaf(new AnimalContext("Snow",   1, "Потребує догляду"), rabbit);

            penA1.Add(a1);
            penA1.Add(a3);
            penA2.Add(a2);
            penB1.Add(a4);

            zoneA.Add(penA1);
            zoneA.Add(penA2);
            zoneB.Add(penB1);
            shelter.Add(zoneA);
            shelter.Add(zoneB);

            // ---- Демонстрація Composite-операцій ----
            Console.WriteLine("1) Подача їжі всім тваринам у Shelter (глибокий обхід):");
            shelter.FeedAll();

            Console.WriteLine("\n2) Друк структури Shelter:");
            shelter.Print(indent: 0);

            Console.WriteLine("\n3) Підрахунок місячних витрат догляду по дереву:");
            var total = shelter.GetMonthlyCareCost();
            Console.WriteLine($">>> Разом по Shelter: {total:0.00} UAH");

            Console.WriteLine("\n4) Показник повторного використання Flyweight:");
            Console.WriteLine(factory.DumpStats());

            Console.WriteLine("\nГотово. Натисніть Enter для виходу...");
            Console.ReadLine();
        }
    }
}
