using System;

public class VirtualPrinter
{
    // Приватне статичне поле для збереження єдиного екземпляру класу
    private static VirtualPrinter instance;

    // Приватний конструктор, щоб заборонити створення екземплярів класу ззовні
    private VirtualPrinter()
    {
        // Ініціалізація будь-яких ресурсів принтера, які можуть бути потрібні
    }

    // Публічний статичний метод для отримання єдиного екземпляру класу
    public static VirtualPrinter GetInstance()
    {
        // Якщо екземпляр ще не створений, створити його
        if (instance == null)
        {
            instance = new VirtualPrinter();
        }
        // Повернути єдиний екземпляр класу
        return instance;
    }

    // Метод для друку документів
    public void PrintDocument(string document)
    {
        Console.WriteLine("Printing document: " + document);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Отримання єдиного екземпляру класу VirtualPrinter
        VirtualPrinter printer = VirtualPrinter.GetInstance();

        // Використання принтера для друку документів
        printer.PrintDocument("Employee report");
        printer.PrintDocument("Salary statement");
        printer.PrintDocument("Financial documents");
    }
}
