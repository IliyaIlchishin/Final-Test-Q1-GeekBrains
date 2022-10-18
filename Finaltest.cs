void FillArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Please enter text into array cell # {i}");
        array [i] = System.Console.ReadLine();
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"# {i} - {array[i]} ");
    }
}


string [] Words = new string[4]; 
FillArray(Words); 
PrintArray (Words);



