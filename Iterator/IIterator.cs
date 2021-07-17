namespace Iterator
{
    public interface IIterator<out T>
    {
        void Next();
        T GetCurrent();
        bool HasNext();
    }
}