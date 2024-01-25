class Program
{
    static void Main(string[] args)
    {
        int[,] multiSizedArray = new int[2,3];

        multiSizedArray[1,2] = 5;

        int[,] multiSizedArray2 = {{1,2,3},{4,5,6}};
        //jagged arrays
        int[] jaggedArray = new int[][]
        {
            new int[]{1,3,5,7,9},
            new int[]{0,2,4,6},
            new int[]{11,12}
        };
    }
    
}