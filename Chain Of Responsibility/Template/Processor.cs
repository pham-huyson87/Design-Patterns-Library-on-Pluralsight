namespace Chain_Of_Responsibility.Template
{
    public class Processor : IProcessor
    {
        private int _greaterLimit;


        public Processor(int greaterLimit)
        {
            _greaterLimit = greaterLimit;
        }

        public Response Process(int dataToProcess)
        {
            if (dataToProcess > _greaterLimit)
                return Response.CannotHandle;
            else
                return Response.CanHandle;
        }
    }
}
