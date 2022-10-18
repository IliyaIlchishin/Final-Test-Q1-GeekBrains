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
        if (array[i].Length <= 0)
        {
            System.Console.WriteLine();
        }
        else System.Console.WriteLine($"# {i} - {array[i]} ");
    }
}

string [] ThreeSignsArray (string [] array)

{
   
    string [] NewArray = new string [array.Length];
    int NewArrayIndex = 0 ;

        for (int i=0; i<array.Length; i++)
        {
            if (array [i].Length <=3)
            {
                NewArray[NewArrayIndex] = array[i]; 
                NewArrayIndex ++;
            }

        }
    return NewArray;
}


string [] Words = new string[4]; 
FillArray(Words); 
PrintArray (Words);

System.Console.WriteLine();

string [] ShortWords = ThreeSignsArray(Words); 
PrintArray (ShortWords);