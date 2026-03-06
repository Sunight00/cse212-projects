public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var numbers = new List<int>();
        var list01 = 0;
        var list02 = 0;
        foreach ( int i in select)
        {
            if(i==1)
            {
                numbers.Add(list1[list01]);
                list01++;
            }
            else
            {
                numbers.Add(list2[list02]);
                list02++;
            }
        }
        return numbers.ToArray();
    }
}