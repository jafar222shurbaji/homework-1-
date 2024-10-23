// def the array

int[] arr = new int[50];

int st = 25;

// add numbers to the array

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = st;
    st++;
}

// sorting the array 
static int [] Sort(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length - 1; j++)
        {
            if (arr[i] > arr[j])
            {    
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

// getting the numbers 
Console.WriteLine("Enter the number you search about: ");
int key = Convert.ToInt32(Console.ReadLine());

// binary search 
static int bina(int[] arr, int key)
{
    int start = 0;
    int end = arr.Length - 1;

    while (start <= end)
    {
        int middle_index = (start + end) / 2;
        if (arr[middle_index] == key)
            return middle_index;

        if (arr[middle_index] < key)
            start = middle_index + 1;

        else
            end = middle_index - 1;

    }
    return -1;
    
}


// Main 
int [] sorted_array =  Sort(arr);
if (bina(sorted_array, key) == -1)
    Console.WriteLine("Number not found");


// --------------------------------------------------------


static int LinearSearch(int[] arr, int target, int index)
{
    if (index > arr.Length -1)
        return -1;
    // Target not found

    if (arr[index] == target)
        return index;
    // Target found at current index

    return LinearSearch(arr, target, index + 1);
}

int[] arr1 = new int[] { 2, 6, 8, 7, 4 };

int target = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine(LinearSearch(arr1, target, 0));
