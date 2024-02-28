// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Add();
//Add();
//Hesapla(20, 15);
//Console.WriteLine("Toplama İşleminin Sonucu: " + Hesapla(20, 45));
//Console.WriteLine(Multipy(26,50));
//Console.WriteLine(Multipy2(26,50,45));
Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine(Add5(1, 2, 3, 4, 5, 6, 7, 8, 9));
//int sayi1 = 25;
//int sayi2 = 50;
//var result = Hesaplaİki(sayi1, sayi2);
//Console.WriteLine(result);

//int sayi1 = 75;
//int sayi2 = 50;
//var method = Çıkarma(sayi1,sayi2);
//Console.WriteLine("Çıkarma İşleminin Sonucu: "+ method);
//Console.WriteLine(sayi1);

//int sayi1 = 20;
//int sayi2 = 20;
//Console.WriteLine("İki Sayı Eşit Mi?: " + Deger(sayi1,sayi2));

static void Add()
{
    Console.WriteLine("Method!");
}

static int Hesapla(int sayi1, int sayi2)
{
    var result = sayi1 + sayi2;
    return result;
}

static int Hesaplaİki(int sayi1, int sayi2)
{
    sayi1 = 30; //global alanda tanımladığımızı devre dışı bırakıp bu sayı üzerinden işlem yaptı.
    var result = sayi1 + sayi2;
    return result;
}

static int Çıkarma(int sayi1, int sayi2)
{
    var result = sayi1 - sayi2;
    return result;
}

static bool Deger(int sayi1, int sayi2)
{
    if (sayi1 == sayi2) // iki sayı birbirine eşit ise true değerini döner.
    {
        return true;
    }
    return false; // else anlamına gelir.
}

static int Multipy(int number1, int number2)
{
    return number1 * number2;
}
static int Multipy2(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}

//params keywords (işlem yapılacak olan ifadeleler için dizi şeklinde tanımlamamıza izin veriyor ve herhangi bir sınırı yoktur.)
static int Add5(params int[] numbers) //console.Writeline içine girilin değerlerin hepsini toplar ve ekrana yazdırır.
{
    return numbers.Sum();
}

static int Add4(int number, params int[] numbers) // paramsdan önce number dediğim için dizideki ilk rakamı number a atadı ve diziden bir sayı eksiltmiş oldu.
{
    return numbers.Sum();
}