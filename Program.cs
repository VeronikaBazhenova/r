void Trial(int [] ar, int size, int root)
{
    int largest = root;
    int firstchild= 2*largest+1;
    int secondchild=2*largest+2;

    if(firstchild<size&&ar[firstchild]>ar[largest])
        largest=firstchild;

    if (secondchild<size&&ar[secondchild]>ar[largest])
        largest=secondchild;

    if (largest!=root)
    {
        int temp=ar[root];
        ar[root]=ar[largest];
        ar[largest]=temp;
    }
    
}

void HeadSort(int[]ar)
{
    for (int i = ar.Length/2-1; i >=0; i--)
        Trial(ar,ar.Length,i);
     for (int i = ar.Length-1; i >=0; i--)
     {
        int temp=ar[0];
        ar[0]=ar[i];
        ar[i]=temp;
        Trial(ar,i, root:0);
     }   

}