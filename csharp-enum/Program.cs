Console.WriteLine(gunler.Pazar);
Console.WriteLine((int)gunler.Cumartesi);
int sıcaklık = 32;
if (sıcaklık <= (int)HavaDurumu.Normal)
{
     Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekle");

} else if (sıcaklık>=(int)HavaDurumu.Sıcak)
    
{
 Console.WriteLine("Dışarıy çıkmak için sıcak bir gün ");   
}else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.Coksicak)
{
    Console.WriteLine("Hadi dışarıya çıkalım!");
}
enum gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar, 
}

enum HavaDurumu
{
    Soguk=5,
    Normal=20,
    Sıcak=25,
    Coksicak=30,
}