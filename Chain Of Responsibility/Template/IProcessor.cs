namespace Chain_Of_Responsibility.Template
{
    public interface IProcessor
    {
        Response Process(int dataToProcess);
    }
}
