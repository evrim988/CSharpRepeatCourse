// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var number = 20;

if (number >= 0 && number <= 100) //burda "ve" nin anlamı, iki koşulu da sağlıyorsa if in içine girer. number değeri 0 dan büyükse ve 0 a eşitse; number değeri 100 den küçükse ve 100 e eşitse koşul doğru bir şekilde sağlanmış olur.
{
    Console.WriteLine("number değeri 0 ile 100 değeri arasındadır.");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("number değeri 100 ile 200 aralığındadır.");
}
else if (number > 200 || number < 0) // burdaki veya nın anlamı iki koşuldan birini sağlıyorsa if in içine girer. number değeri 200 den büyükse veya number değeri 0 dan küçükse if in içine girer ve consola yazdırır.
{
    Console.WriteLine("number değeri 200 den büyük veya 0 değerinden küçüktür.");
}


var number2 = 220;

if (number2 >= 0 && number2 <= 100)
{
    Console.WriteLine("number2 değeri sıfırdan büyüktür.");
}
else if (number2 >= 100 && number2 <= 200)
{
    Console.WriteLine("number2 değeri 100 ile 200 arasındadır.");
}
else
{
    Console.WriteLine("number2 değeri 200 dan büyüktür.");
}