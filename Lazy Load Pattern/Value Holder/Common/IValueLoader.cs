namespace Lazy_Load_Pattern.Value_Holder
{
    public interface IValueLoader<T>
    {
        T Load();
    }
}
