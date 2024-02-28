// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//for (int i = 0; i < 100; i++) //sıfırdan 100 e kadar olan sayıları ekrana yazdırır.
//{
//    Console.WriteLine(i);
//}

//for (int i = 1; i < 100; i += 2) //birden 100 e kadar tek sayılar ekrana yazdırır.
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 100; i += 2) //sıfırdan 100 e kadar 100 e kadar sayıları ekrana yazdırır.
//{
//    Console.WriteLine(i);
//}

//for(int i = 100; i >= 0; i--) //yüzden başlayıp 1er 1er azalta azalta 0 a kadar ekrana yazdırır.
//{
//    Console.WriteLine(i);
//}

//While döngüsü

//int number = 100;
//while (number >= 0) //belli bir şart sağlanana kadar döngü çalışır.
//{
//    number--;  //bunu belirtmeseydik döngü sürekli dönücekti
//    Console.WriteLine(number);
//}

//do-while döngüsü
//int number = 10;
//do
//{
//    number--;
//    Console.WriteLine(number);
//} while (number >=0 );

//Foreach döngüsü
string[] students = { "Evrim", "Fatma", "Ayşe", "Selime" };
foreach (string item in students)
{
    Console.WriteLine(item);
}