/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.Clear();
int getUserData(string msg)
{
    Console.Write(msg);
    int count = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    return count;
}
int[] createArray(int dimension, int start, int end)
{
    int[] arrayRan = new int[dimension];
    for (int i = 0; i < dimension; i++)
    {
        arrayRan[i] = new Random().Next(start, end + 1);
    }
    return arrayRan;
}
string convertArrayToString(int[] userArray)
{
    string convertArray = "[";
    for (int i = 0; i < userArray.Length; i++)
    {
        if (i != userArray.Length - 1)
        {
            convertArray = convertArray + Convert.ToString(userArray[i]) + ", ";
        }
        else
        {
            convertArray = convertArray + Convert.ToString(userArray[i]) + "]";
        }
    }
    return convertArray;
}
void showResult(string msg, string msg1)
{
    Console.WriteLine($"{msg} {msg1}");
}
int dimensionArray = getUserData("Введите размерность массива: ");
int downLimit = getUserData("Введите нижний предел для случайных чисел: ");
int upLimit = getUserData("Введите верхний предел для случайных чисел: ");
int[] array = new int[dimensionArray];
array = createArray(dimensionArray, downLimit, upLimit);
string arrayString = convertArrayToString(array);
showResult($"Создан массив из {dimensionArray} случайных чисел, в пределах от {downLimit} до {upLimit}:", arrayString);