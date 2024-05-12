namespace task4;

public static class  SortArrey
{
    public static int[] Sort(this int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
        return array;
    }
    
    static void Swap(ref int e1, ref int e2)
    {
        int temp = e1;
        e1 = e2;
        e2 = temp;
    }
}