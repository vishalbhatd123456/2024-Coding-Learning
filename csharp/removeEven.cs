class Solution
{
    public static int[] removeEven(int [] arr, int size)
    {
        int m = 0;
        for(int i = 0; i < size;i++)
        {
            if(arr[i]%2!=0)
            {
                arr[m] = arr[i];
                ++m;
            }
        }
        int[] temp = new int[m];
        for(int i = 0;i < m;i++)
        {
            temp[i] = arr[i];
        }
        arr = temp;
        return arr;
    }
}