// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] students = new string[3]; //3 elemanlı bir string dizi tanımlıcam dedim.
students[0] = "Evrim";
students[1] = "Ayşe";
students[2] = "Zeynep";

/*Console.WriteLine(students);*/ // böyle yazdığım zaman ekrana saçma birşey yazdı. Ancak ben hepsini alt alta yazdırmak istiyorum.

//foreach (var item in students)
//{
//    Console.WriteLine(item); //student dizisinin her bir elemanını döngü sonucunda ekrana yazdırır.
//}
////iki türlü de bu şekilde array tanımlayabiliriz.
//string[] students2 = new string[2] { "Evrim", "Kadriye" };
//string[] students3 = { "Evrim", "Fatma", "Ayşe", "Selime" };
//students3[4] = "Fadime"; //bu şekilde diziye eleman ekleyebiliriz.

//Çok Boyutlu Diziler
string[,] regions = new string[2, 3]
{
    {"İstanbul","Bursa","Kocaeli"},
    {"İzmir","Manisa","Muğla"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++) //ilk satırdan itibaren başlar.
{

    for (int j = 0; j <= regions.GetUpperBound(1); j++) //ilk sütundan itibren başlar.
    {
        Console.WriteLine(regions[i, j]);
    }
}