using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();

            //double applePrice = 14.85;
            //double orangePrice = 20.95;
            //double strawberryPrice = 45;
            //double potatoPrice = 9.74; 
            //double tomatoPrice = 6.88;


            //Console.WriteLine("****** Manav Fiyatları ******");
            //Console.WriteLine();
            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //double appleGram = 1.245;
            //double orangeGram = 2.650;
            //double strawberryGram = 0.750;
            //double potatoGram = 4.859;
            //double tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + "TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");

            //Console.Read();

            #endregion

            #region Char Değişkenler

            //char symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.Read();


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("****** C# Airlines ******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerProvince, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerProvince = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine(); 

            //Console.WriteLine();

            //Console.WriteLine("-----------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Bilgileri");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerProvince + " / " +
            //    passengerCity + " " + passengerAge);

            //Console.Read();

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            // ABC12D

            //int shoesPrice = 1000;
            //int computerPrice = 20000;
            //int chairPrice = 5000;
            //int tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldğınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount= int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("-----------------------");

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount *chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            //Console.Read();

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());  

            //result =(exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);
            //Console.Read();

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçilen cinsiyet: " + gender);
            //Console.Read();

            #endregion


        }
    }
}
