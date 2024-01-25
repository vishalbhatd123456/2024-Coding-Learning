class example_1
{
    static void Main(string[] args)
    {
        ArrayList arr = new ArrayList(1);

        arr.insert(1);
        arr.insert(1);
        arr.insert(1);
        arr.insert(1);
        arr.insert(1);
        Console.WriteLine("the size of the array list:"+arr.length());
    }
}
class ArrayList
{
    int[] arr;
    int num_elements;
    int capacity;

    public ArrayList(int size)
    {
        arr = new int[size];
        num_elements = 0; //initial capacity
        capacity = size;
    }
    public void insert(int val)
    {
        if(num_elements < capacity)
        {
            Console.WriteLine("adding element"+val+"and at the position"+num_elements);
            //there is space to add, then add to the end of the array
            arr[num_elements] = val;
            num_elements++; 
            Console.WriteLine("the size of the array list after ddition is"+num_elements);
        }
    }
    public int getAt(int index)
    {
        return arr[index];
    }
    public void resize(int multiplier)
    {
        int[] tempA = new int[capacity*multiplier];

        for(int i = 0l i < num_elements;i++)
        {
            tempA[i] = arr[i];
        }
        arr = tempA; //resized arr, dynamic allocation
    }
    public int length()
    {
        return num_elements;
    }
    public void print()
    {
        for(int i = 0;  i < num_elements;i++)
        {
            Console.WriteLine(arr[i]+" ");
        }
    }
}