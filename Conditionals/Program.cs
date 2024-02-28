// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var number = 20;
var number2 = 11;

//ilk koşulu kontrol eder eğer doğruysa girer doğru değilse ikinic koşula geçer oda doğru değilse üçüncü koşula geçer en son üçüncü koşulu sağlayıp çıkar.
//if (number == 10)
//{
//    Console.WriteLine("Girilen sayı 10'dur");
//}
//else if(number2 == 11)
//{
//    Console.WriteLine("Girilen İkinci sayı değeri 11 dir");
//}
//else 
//{
//    Console.WriteLine("Girilen Sayı 10 değildir.");
//}

var number3 = 26;
Console.WriteLine(number3 == 26 ? "Üç numaralı sayınız 26" : "Üç numaralı sayınız 26 değildir"); //ilk soru işaretine kadar koşulu kontrol ediyor eğer koşul doğruysa ilk text i getirir.Değilse üç nokta sonrasındaki ekrana yazdırır. //bu kurala single line if deniyor.

var number4 = 120;

switch (number4)
{
    case 10:
             Console.WriteLine("Girilen sayı 10'dur");
        break;
    case 20:
        Console.WriteLine("Girilen İkinci sayı değeri 20 dir");
        break;
    default:
        Console.WriteLine("Girilen sayı değeri 10 veya 20 değildir.");
        break;
}