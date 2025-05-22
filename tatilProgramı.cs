void tatilProgramı()
{ 
string lokasyon = "";
bool gecerliMi = true;
int toplamMasraf = 0;

Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");

while (gecerliMi)
{
   
    Console.WriteLine("Gitmek istediğiniz lokasyonu giriniz: ");
    lokasyon = Console.ReadLine().ToLower();

    if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
    {
        gecerliMi = false;
        if (lokasyon == "bodrum")
        {
            toplamMasraf += 4000;
            Console.WriteLine("Bodrum seçtiniz.");
        }
        else if (lokasyon == "marmaris")
        {
            toplamMasraf += 3000;
            Console.WriteLine("Marmaris seçtiniz.");
        }
        else if (lokasyon == "çeşme")
        {
            toplamMasraf += 5000;
            Console.WriteLine("Çeşme seçtiniz.");
        }
    }
    else
    {
        Console.WriteLine("Hatalı giriş! Lütfen sadece aşağıdaki lokasyonlardan birini giriniz:");
        Console.WriteLine("--> Bodrum");
        Console.WriteLine("--> Marmaris");
        Console.WriteLine("--> Çeşme");
    }
}
Console.WriteLine($"Tatile Gitmek İstediğiniz Kişi Sayısı -> ");
int kisiSayisi = int.Parse(Console.ReadLine());
if (lokasyon =="bodrum")
{
    Console.WriteLine("Bodrumda gezebileceğiniz örnek yerler:");
    Console.WriteLine("Gümbet – Su sporları ve hareketli plajlar için ideal.");
    Console.WriteLine("Antik Tiyatro – Akşam konserleri için harika bir ortam.");
    Console.WriteLine("Barlar Sokağı – Canlı müzik, kulüpler, barlar (özellikle gençler için).");
}
else if (lokasyon == "marmaris")
{
    Console.WriteLine("Marmariste gezebileceğiniz örnek yerler:");
    Console.WriteLine("İçmeler – Plaj ve su sporları için harika bir yer.");
    Console.WriteLine("Marmaris Kalesi – Tarihi bir mekan ve güzel manzaralar.");
    Console.WriteLine("Turunç – Sakin plajlar ve güzel doğa yürüyüşleri.");
}
else if (lokasyon == "çeşme")
{
    Console.WriteLine("Çeşmede gezebileceğiniz örnek yerler:");
    Console.WriteLine("Alaçatı – Rüzgar sörfü ve güzel sokaklar.");
    Console.WriteLine("Çeşme Kalesi – Tarihi bir mekan ve güzel manzaralar.");
    Console.WriteLine("Ilıca Plajı – Sıcak su kaynakları ve güzel plajlar.");
}
Console.WriteLine("Lütfen ulaşım şeklini seçiniz:");
Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
int ulasim = int.Parse(Console.ReadLine());
if (ulasim == 1)
{
    toplamMasraf += kisiSayisi * 1500;
    Console.WriteLine("Toplam " + kisiSayisi + " kişi ile yapacağınız " + lokasyon + " tatilinde masrafınız " + toplamMasraf + " TL olacaktır.");
}
else if (ulasim == 2)
{
    toplamMasraf += kisiSayisi * 4000;
    Console.WriteLine("Toplam " + kisiSayisi + " kişi ile yapacağınız " + lokasyon + " tatilinde masrafınız " + toplamMasraf + " TL olacaktır.");
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız. Tekrar deneyiniz.");
}
}
tatilProgramı();
Console.WriteLine("Yeniden hesaplamak isterseniz 1'i Programdan Çıkmak İçin 2'yi Kullanınız.");
int secim = int.Parse(Console.ReadLine());
if (secim == 1)
{
    Console.WriteLine("Program yeniden başlatılıyor...");
    tatilProgramı();
}
else if (secim == 2)
{
    Console.WriteLine("Programdan çıkılıyor.İyi Günler Dileriz.");
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız programdan çıkılıyor.İyi Günler Dileriz");
}