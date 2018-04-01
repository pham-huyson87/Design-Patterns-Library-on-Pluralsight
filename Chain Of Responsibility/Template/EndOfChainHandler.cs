using System;

namespace Chain_Of_Responsibility.Template
{
    public class EndOfChainHandler : IHandler
    {
        private static readonly EndOfChainHandler _instance;


        private EndOfChainHandler() { }

        public static EndOfChainHandler Instance
        {
            get { return _instance;  }
        }

        public Response HandleRequest(int data)
        {
            return Response.NoExistingProcessorCanHandle;
        }

        public void RegisterNextHandler(IHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
    }
}
