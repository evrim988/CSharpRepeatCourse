// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Merhaba Dünya");

int number1 = 10;
int number2 = 20;
//Console.WriteLine("Numara 1: {0}{1}",number1,number2);

int number3 = 3000000; // 32 bitlik yer kaplar.
Console.WriteLine(number3);

long number4 = 1000000000000; //büyük veri tipleri için geçerlidir. 64 bitlik yer kaplar.
Console.WriteLine(number4);

short number5 = 15545; //16 bitlik yer kaplar.
Console.WriteLine(number5);

byte number6 = 255; //byte; 0 ile 255 arasında değer tutar (256 yazdığımda kabul etmiyor yani hata veriyor.)
Console.WriteLine(number6);

bool Active = true; //true yada false değeri tutar.
Console.WriteLine(Active);

char character = 'A'; //tek karakterleri tutmak için kullanılır.
Console.WriteLine(character);
Console.WriteLine((int)character); //Verdiğimiz karakter ASCII karakter tablosunda karşılığında olan sayı değerini verir.

double number7 = 1.05; //ondalıklı ifadeleri tutmak için kullanılır.
Console.WriteLine(number7);

decimal number8 = 10.45m; //daha hassas hesaplama işlemlerde kullanılır.
Console.WriteLine(number8);


Console.WriteLine(Days.Thursday);


var number9 = 10; //değişkenleri tutmak için kullanılır.
number9 = 'A'; //böyle tanımladığımızda değişkeni artık int kabul ettiği için burda int değer döner.
Console.WriteLine(number9);

enum Days  //Dinamik olarak veri tutmak için çok faydası olur.Bir değişklik yapıldığında her yerden tek tek değiştirmek yerine bi yerden değiştirmeye faydası olur.
{
    Monday,Tuesday, Wednesday,Thursday,Friday
}


