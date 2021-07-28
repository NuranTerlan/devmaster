using System.Collections.Generic;

namespace Observer
{
    public interface IObserver
    {
        void Reload(IEnumerable<int> values);
    }
}