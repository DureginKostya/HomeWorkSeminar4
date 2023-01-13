/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();
int getUserNumber(string msg)
{
    Console.Write(msg);
    int variable = int.Parse(Console.ReadLine()!);    
    return variable;
}
int getDegreeOfNumber(int variable, int index)
{
    int composition = 1;
    for (int i = 0; i < index; i++)
    {
        composition = composition * variable;
    }
    return composition;
}
void showResult(string msg, int result)
{
    Console.Write(msg);
    Console.WriteLine(result);
}
int number = getUserNumber("Введите число: ");
int degree = getUserNumber($"Введите степень, в которую нужно возвести число {number}: ");
int degreeNumber = getDegreeOfNumber(number, degree);
showResult($"Ответ: {number} ^ {degree} = ", degreeNumber);