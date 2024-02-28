// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string message = "Merhaba Dünya";

var lenght = message.Length;
Console.WriteLine(lenght);
var cloneMessage = message.Clone();
message = "Hello World!";

Console.WriteLine(cloneMessage);

bool result = message.EndsWith("a");
bool resut2 = message.StartsWith("Merhaba");
var result3 = message.IndexOf("dünya");
var result4 = message.IndexOf(" ");
var result5 = message.LastIndexOf(" ");
var result6 = message.Insert(0, "Hi!, ");
var result7 = message.Substring(3);
var result8 = message.ToLower();
var result9 = message.ToUpper();
var result10 = message.Replace(" ", ".");
var result11 = message.Remove(0, 1);

Console.WriteLine(result8);
