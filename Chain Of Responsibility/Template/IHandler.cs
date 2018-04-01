namespace Chain_Of_Responsibility.Template
{
    public interface IHandler
    {
        Response HandleRequest(int data);
        void RegisterNextHandler(IHandler next);
    }
}
