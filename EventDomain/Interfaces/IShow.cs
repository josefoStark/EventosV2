namespace EventDomain
{
    public interface IShow
    {
        void ShowMessage(string message);

        void WaitApplication();
    }
}