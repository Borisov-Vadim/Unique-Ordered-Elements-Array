using UniqueOrderedArray;

List<char> result1 = UniqueOrderedElementsArray.GetUniqueElementsInOrder("XBBHhLM");
Console.WriteLine(string.Join(" ", result1));

List<int> result2 = UniqueOrderedElementsArray.GetUniqueElementsInOrder(new List<int> { 1, 1, 5, 5, 7, 8, 8, 8 });
Console.WriteLine(string.Join(" ", result2));
