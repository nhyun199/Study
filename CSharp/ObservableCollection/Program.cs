namespace ObservableCollection
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Observer<Pair<string>> observer = new Observer<Pair<string>>();
            observer.OnItemChanged += (id, item) => Console.WriteLine($"ID : {id}, ITEM : {item.item}으로 변경되었습니다!");
            observer.OnItemAdded += (id, item) => Console.WriteLine($"ID : {id}, ITEM : {item.item}이 추가되었습니다!");
            observer.OnItemRemoved += (id, item) => Console.WriteLine($"ID : {id}, ITEM : {item.item}이 삭제되었습니다!");
            observer.OnCollectionChanged += () => Console.WriteLine($"Observer가 변경되었습니다!\n");

            observer.Add(new Pair<string>(0, "Red Potion"));
            observer.Add(new Pair<string>(1, "Blue Potion"));
            observer.Add(new Pair<string>(2, "White Potion"));

            observer.Changed(0, new Pair<string>(0, "Black Potion"));

            observer.Remove(2);

            
        }
    }

}