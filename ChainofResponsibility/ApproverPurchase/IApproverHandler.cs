namespace ChainofResponsibility
{
    public interface IApproverHandler
    {
        IApproverHandler SetNext(IApproverHandler handler);

        object Handle(Purchase handler);
    }
}
