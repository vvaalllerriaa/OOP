using System;
using Lib;

class Program {
    static void Main() {
        TextContainer myText = new TextContainer();
        
        myText.AddLine("hello world");
        myText.AddLine("object oriented programming");

        Console.WriteLine("Ключ для першого рядка: " + myText.GetKeyFromWords("hello world"));
        
        myText.CapitalizeAll();
        Console.WriteLine("Після підняття регістру:");
        foreach (var line in myText.GetAllLines()) Console.WriteLine(line);
    }
}