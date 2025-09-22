namespace AnimalShelterStructural.Composite
{
    /// <summary>
    /// Component: спільний інтерфейс для вузлів та листя дерева притулку.
    /// </summary>
    public interface IEnclosureComponent
    {
        string Name { get; }

        /// <summary> Друк вузла з відступами (стуб-візуалізація структури). </summary>
        void Print(int indent);

        /// <summary> Подати їжу всім тваринам у піддереві/листку. </summary>
        void FeedAll();

        /// <summary> Сумарна вартість догляду в піддереві/листку. </summary>
        decimal GetMonthlyCareCost();
    }
}
