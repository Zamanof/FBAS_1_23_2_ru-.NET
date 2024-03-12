// Generic collections

// Generic                          non generic

// List<T>                          ArrayList
// Dictionary<TKey, TValue>         HashTable
// SortedList<TKey, Tvalue>         SortedList
// Stack<T>                         Stack
// Queue<T>                         Queue
// LinkedList<T>                    -

List<int> ints = new();
for (int i = 0; i < 15; i++)
{
    ints.Add(i);
}
Console.WriteLine(ints[0].GetType());
Console.WriteLine(ints[0] + 12);

