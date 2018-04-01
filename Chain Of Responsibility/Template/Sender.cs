namespace Chain_Of_Responsibility.Template
{
    public class Sender
    {
        private Handler handlerA = new Handler(new Processor(10));
        private Handler handlerB = new Handler(new Processor(100));
        private Handler handlerC = new Handler(new Processor(1000));
        private Handler handlerD = new Handler(new Processor(10000));


        public Sender()
        {
            handlerA.RegisterNextHandler(handlerB);
            handlerB.RegisterNextHandler(handlerC);
            handlerC.RegisterNextHandler(handlerD);
        }

        public Response Send(int input)
        {
            return handlerA.HandleRequest(input);
        }
    }
}
