// Работа с текстом 
// Дан текст. В тексте все пробелы нужно заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежеле вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newtext = Replace(text, ' ' , '-');
Console.WriteLine(newtext);
Console.WriteLine();

string newnewtext = Replace(newtext, 'к' , 'К');
Console.WriteLine(newnewtext);
Console.WriteLine();

string newnewnewtext = Replace(newnewtext, 'C' , 'c');
Console.WriteLine(newnewnewtext);