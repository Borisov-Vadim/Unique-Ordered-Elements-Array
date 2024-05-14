namespace UniqueOrderedArray;

public static class UniqueOrderedElementsArray
{
    public static List<T> GetUniqueElementsInOrder<T>(IEnumerable<T> input)
    {
        List<T> result = new List<T>();
        T? previous = default;

        foreach (var item in input)
        {
            if (!item.Equals(previous))
            {
                result.Add(item);
                previous = item;
            }
        }

        return result;
    }
}
