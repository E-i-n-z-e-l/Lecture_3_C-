//Какие бывают методы

// Вид 1 - методы которые ничего не принимают и ничего не возвращают

void Methot1()
{
    Console.WriteLine("Автор ...");
}
Methot1();


// Вид 2 - методы которые принимают что-то, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}

Method21("Танечка ", 5);


// Вид 3 - методы которые ничего не принимают, но возвращают значения

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// Вид 4 - методы которые что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // string.Empty - пустая строка

    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Танюшка ");
Console.WriteLine(res);