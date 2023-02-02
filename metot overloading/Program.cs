// mett overlading  out parametreler
string sayi="444";
int outsayi;
bool sonuc=int.TryParse(sayi, out outsayi);
if (sonuc)
{
    Console.WriteLine("başarlı");
    Console.WriteLine("444");

}
else
{
    Console.WriteLine("başarısız");
}
Metotlar instance =new Metotlar();
instance.Topla(3,1,sayi, out int toplamSonucu);
Console.WriteLine(toplamSonucu);
// overloading aşırı yükleme
int ifade= 555;
instance.EkranaYazdır(ifade);
instance.EkranaYazdır("ömer"," faruk");



class Metotlar
{
    public void Topla(int a, int b,string c,out int toplam)
    {
        toplam =  a+b;
    }
public void EkranaYazdır(string veri)
{
     Console.WriteLine(veri);
}
public void EkranaYazdır(int veri)
{
     Console.WriteLine(veri);
}
public void EkranaYazdır(string veri1,string veri2)
{
     Console.WriteLine(veri1+veri2);
}
}

