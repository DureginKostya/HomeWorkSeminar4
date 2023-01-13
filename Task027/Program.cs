/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
int getUserNumber(string msg)
{
    Console.Write(msg);
    int variable = int.Parse(Console.ReadLine()!);    
    return variable;
}
int getDigitOfNumber(int reducedNumber)
{
    reducedNumber = reducedNumber % 10;
    return reducedNumber;
}
void getSumOfDigit(int variable, out int sumDigit)
{  
    sumDigit = 0;
    while (variable > 0)
    {
        sumDigit = sumDigit + getDigitOfNumber(variable);
        variable = variable / 10;
    }
}
string getNumberInString(int userNumber)
{
    string numberStr = Convert.ToString(userNumber);
    string newNumberStr = String.Empty;
    for (int i = 0; i < numberStr.Length; i++)
    {
        newNumberStr = newNumberStr + numberStr[i];
        if (i != numberStr.Length - 1)
        {
            newNumberStr = newNumberStr + " + ";
        }
    } 
    return newNumberStr;
}
void showResult(string msg, int result)
{
    Console.WriteLine($"{msg} = {result}");
}
int number = getUserNumber("Введите число: ");
int sum;
getSumOfDigit(number, out sum);
string numberString = getNumberInString(number);
showResult($"Ответ: {numberString}", sum);