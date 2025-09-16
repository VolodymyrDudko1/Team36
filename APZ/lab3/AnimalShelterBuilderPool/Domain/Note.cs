namespace AnimalShelterBuilderPool.Domain
{
/// <summary> Примітка до профілю. </summary>
public sealed class Note
{
public Note(string text) { Text = text; }
public string Text { get; }
public override string ToString() => Text;
}
}