int[] massive = {2,5,6,8,1,0,3,5,0 };

static int[] BubbleSort(ref int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = 0; j < mas.Length - i - 1; j++)
        {
            if (mas[j + 1] < mas[j])
            {
                temp = mas[j + 1];
                mas[j + 1] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

BubbleSort(ref massive);

for (int i = 0; i < massive.Length; i++)
{
    Console.WriteLine(massive[i] + "\n");
}
