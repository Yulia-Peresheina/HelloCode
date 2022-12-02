// 1  группа
// не принимают и не возвращают

void Method1()
{
    Console.WriteLine("Автор - Перешеина Ю.Е.");
}

//вызываются так:

Method1();

//2 группа

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(count: 4, msg: "Новый текст");

// группа 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// 4 группа принимает и возвращает

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i< count; i++)
    {
        result = result + text;
    }
    return result;

}

string res = Method4(4, "z");
Console.WriteLine(res);