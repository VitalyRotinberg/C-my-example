int [] array = {61,272,23,74,15,56,27,15,9};

int n = array.Length;
int find = 15;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}