string[] arrayStringStart = { "hello", "2", "world", "!", "yes" };
string[] arrayStringEnd = new string[arrayStringStart.Length];
int index = 0;

string[] ChangeArray(string[] arrayStringStart)
{
    for (int i = 0; i < arrayStringStart.Length; i++)
        if (arrayStringStart[i].Length <= 3)
        {
            arrayStringEnd[index] = arrayStringStart[i];
            index += 1;
        }
    return arrayStringEnd;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

ShowArray(ChangeArray(arrayStringStart));
