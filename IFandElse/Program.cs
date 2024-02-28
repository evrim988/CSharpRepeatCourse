// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var ogrNot = 55;

if(ogrNot > 50)
{
    Console.WriteLine("Tebrikler Geçtiniz...");
}
else
{
    Console.WriteLine("Maalesef kaldınız");
}

var ogrNot1 = 65;
var ogrNot2 = 40;
var ogrNot3 = 70;

var sonuc = (ogrNot1 + ogrNot2 + ogrNot3) / 3;

if(sonuc > 50)
{
    Console.WriteLine("Tebrikler Dersi Geçtiniz");
}
else
{
    Console.WriteLine("Maalesef Dersi Geçemediniz");
}

int a = 0;
if (a <= 0) // 0 dan küçük ve 0 a eşitse dediğimiz için if in içine girdi.
    Console.WriteLine("Pozitif Bir Sayı Giriniz.");

var not = 75;

if(not <0 )
{
    Console.WriteLine("Geçersiz bir not giriniz.");
}
else if(not >= 0 && not < 50)
{
    Console.WriteLine("Notunuz 50 den küçük ve 0 dan büyüktür");
}
else if(not < 40)
{
    Console.WriteLine("Notunuz 40 den Küçüktür.");
}
else
{
    Console.WriteLine("Geçerli Bir Not Girdiniz");
}


var sayi = 4;

if (sayi % 2 == 0)
    Console.WriteLine("Girdiğiniz sayı çifttir.");
else
    Console.WriteLine("Girdiğiniz sayı tektir.");

var sayi2 = 6;

if (sayi % 2 == 0 && sayi2 % 3 == 0)
    Console.WriteLine("Girilen Sayı hem 2 ye hem de 3 bölünebilir");
else
    Console.WriteLine("Hatalı bir sayı girdiniz.");

var sayi3 = 11;

if (sayi3 % 2 == 0 && sayi3 % 3 == 0)
    Console.WriteLine("Girdiğiniz sayı 2 ve 3 ün katıdır.");
else if (sayi3 % 2 == 0)
    Console.WriteLine("Girdiğiniz sayı sadece 2 nin katıdır.");
else if (sayi3 % 3 == 0)
    Console.WriteLine("Girdiğiniz sayı sadece 3 ün katıdır.");
else
    Console.WriteLine("Girdiğiniz sayi ne 2 ile 3 ün katı değildir.");


