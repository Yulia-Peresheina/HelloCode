// дан текст. В тексте нужно все пробелы заменить черточуками, 
//маленькие буквы "к" заменить большими буквами "К"
//маленькие буквы "с" заменить большими "С"


string text = "– Я думаю, – сказал князь, улыбаясь,"
             + " – что, ежели бы вас послали вместо нашего милого Винценгероде,"
             + " вы бы взяли приступом согласие прусского короля. "
             + "Вы так красноречивы. Вы дадите мне чаю?";

string NewText(string text, char OldValue, char NewValue)
{
    int length = text.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;

}
string newText = NewText(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText2 = NewText(newText, 'к', 'К');
Console.WriteLine(newText2);