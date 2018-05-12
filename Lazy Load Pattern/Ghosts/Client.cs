namespace Lazy_Load_Pattern.Ghosts
{
    class Client
    {
        public Client()
        {
            BusinessObject businessObject = new BusinessObject(1);

            var id = businessObject.Id;                     // No load

            var valueOne = businessObject.PropertyOne;      // Load
            var valueTwo = businessObject.PropertyTwo;      // No load
            var valueThree = businessObject.PropertyThree;  // Load
        }
    }
}
