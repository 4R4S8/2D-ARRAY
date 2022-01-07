
Console.Write("Enter The Length of 1st Demention Array: ");
int firstD = int.Parse(Console.ReadLine());
Console.Write("Enter The Length of 2nd Demention Array: ");
int secondD = int.Parse(Console.ReadLine());
int entery ;
int[,] number = new int[firstD, secondD];
Console.WriteLine();
for (int j = 0; j < firstD; j++)
{
    for (int i = 0; i < secondD; i++)
    {
        Console.WriteLine("{0},{1}",j,i);
        Console.Write("Enter The Number: ");
        entery = int.Parse(Console.ReadLine());
        number[j, i] = entery;
    }
}

Console.WriteLine();
for (int i = 0; i < firstD; i++)
{
    for (int j = 0; j < secondD; j++)
    {
        Console.Write(number[i, j] + " ");
    }
    Console.WriteLine();
}

//foreach ( int a in number)
//{
//    Console.WriteLine(a);
//}