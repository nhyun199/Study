using ObservableCollection;

namespace ObservableCollection
{
    public struct Pair<T>
    {
        public int id;
        public T item;

        public Pair(int id, T item)
        {
            this.id = id;
            this.item = item;
        }
    }

    internal class Observer<T>
    {
        List<Pair<T>> items = new List<Pair<T>>();

        public event Action<int, T>? OnItemChanged;
        public event Action<int, T>? OnItemAdded;
        public event Action<int, T>? OnItemRemoved;
        public event Action? OnCollectionChanged;
        
        public void Changed(int id, T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].id == id)
                {
                    items[i] = new Pair<T>(id, item);
                    OnItemChanged?.Invoke(id, item);
                    OnCollectionChanged?.Invoke();
                    return;
                }
            }
        }

        public void Add(T item)
        {
            int id = items.Count > 0 ? items[items.Count - 1].id + 1 : 0;
            Pair<T> newitems2 = new Pair<T>(id, item);
            items.Add(newitems2);
            OnItemAdded?.Invoke(id, item);
            OnCollectionChanged?.Invoke();
        }

        public bool Remove(int id)
        {
            Pair<T> removeitem = items.Find(x => x.id == id);
            if(removeitem.id != default)
            {
                items.Remove(removeitem);
                OnItemRemoved?.Invoke(id, removeitem.item);
                OnCollectionChanged?.Invoke();
                return true;
            }
            return false;
        }
    }
}


