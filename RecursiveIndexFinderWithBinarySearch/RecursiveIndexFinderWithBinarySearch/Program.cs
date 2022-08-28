using RecursiveIndexFinderWithBinarySearch;

int[] array = { 0, 1, 2, 3, 4, 7, 45, 90, 10000 };

Finder finder = new Finder();

int index = finder.Find(array, 0, array.Length - 1, 200000000);

Console.WriteLine(index);