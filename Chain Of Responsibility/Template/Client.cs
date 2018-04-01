namespace Chain_Of_Responsibility.Template
{
    public class Client
    {
        public Client()
        {
            Sender sender = new Sender();

            Response response = sender.Send(12345);
        }
    }
}
