namespace Chain_Of_Responsibility.Template
{
    public class Handler : IHandler
    {
        private IProcessor _processor;
        private IHandler _next;


        public Handler(IProcessor processor)
        {
            _processor = processor;
            _next = EndOfChainHandler.Instance;
        }

        public Response HandleRequest(int data)
        {
            Response response = _processor.Process(data);

            if (response == Response.CannotHandle)
                return _next.HandleRequest(data);
            else
                return Response.CanHandle;
        }

        public void RegisterNextHandler(IHandler next)
        {
            _next = next;
        }
    }
}
