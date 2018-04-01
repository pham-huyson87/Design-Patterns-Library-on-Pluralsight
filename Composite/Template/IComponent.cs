namespace Composite.Template
{
    interface IComponent
    {
        string Name { get; set; }
        void Operation();
    }
}
