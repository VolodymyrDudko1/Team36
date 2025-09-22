namespace AnimalShelterStructural.Domain
{
    /// <summary>
    /// Абстракція Flyweight: спільний (інваріантний) стан виду/категорії.
    /// </summary>
    public interface IAnimalType
    {
        string Species { get; }
        string Size { get; }
        decimal BaseCareCost { get; }
        string Diet { get; }

        /// <summary> Стуб-метод для демонстрації дії, що використовує екзогенний контекст. </summary>
        void Feed(AnimalContext context);

        /// <summary> Оціночна місячна вартість догляду з урахуванням екзогенного стану (стуб). </summary>
        decimal EstimateMonthlyCareCost(AnimalContext context);
    }
}
