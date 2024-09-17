using System;
class InputConsoleDemo
{
    static void Main()
    {
        //Текстовая переменная
        string name;

        //Заголовок консольного окна
        Console.Title = "Давайте познакомимся...";

        //Сообщение в консоли:
        Console.Write("Как вас зовут? ");

        //Считывание текста
        name=Console.ReadLine();

        //Ещё одна текстовая переменная:
        string txt = "Очень приятно, " + name + "!";

        //Заголовок консольного окна 2:
        Console.Title = "Знакомство состоялось!";

        //Сообщение в консоли 2:
        Console.WriteLine(txt);
    }
}
