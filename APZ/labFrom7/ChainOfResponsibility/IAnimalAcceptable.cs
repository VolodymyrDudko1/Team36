namespace labFrom7.ChainOfResponsibility;

public interface IAnimalAcceptable<T> where T : IAnimalAcceptable<T>
{
    IAnimalAcceptable<T> SetNext(T acceptRequest);
    object Accept(object animal);
}