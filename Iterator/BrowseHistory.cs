namespace Iterator
{
    public class BrowseHistory
    {
        // private readonly List<string> _urls;
        
        private readonly string[] _urls;
        private int _index;

        public BrowseHistory()
        {
            _urls = new string[10];
        }

        public void Push(string url)
        {
            // _urls.Add(url);
            
            _urls[_index++] = url;
        }

        public string Pop()
        {
            // var last = _urls.LastOrDefault();
            // _urls.Remove(last);
            // return last;
            
            var last = _urls[_index];
            _urls[_index++] = "";
            return last;
        }

        public IIterator<string> GetIterator()
        {
            // return new ListIterator(this);

            return new ArrayIterator(this);
        }

        private class ListIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
                _index = 0;
            }
            
            public void Next()
            {
                _index++;
            }

            public string GetCurrent()
            {
                return _history._urls[0];
            }

            public bool HasNext()
            {
                if (_index < _history._urls.Length) return true;
                
                _index = 0;
                return false;

            }
        }

        private class ArrayIterator : IIterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ArrayIterator(BrowseHistory history)
            {
                _history = history;
            }

            public void Next()
            {
                _index++;
            }

            public string GetCurrent()
            {
                return _history._urls[_index];
            }

            public bool HasNext()
            {
                if (_index < _history._urls.Length) return true;
                
                _index = 0;
                return false;
            }
        }
    }
}