using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int deger=2;
           string degisken="Deneme";
           string degisken2=null;
           string Degisken=" ";

           byte by=5;        //1 byte 0..255
           sbyte sby =10;    // 1 byte -128..+127

           short s=5;       // 2byte -32768..+32767
           ushort us=2;     //2 byte 0..65365

           Int16 i16=32;    //2 byte
           int i=10;        // 4 byte
           Int32 i32=4;     //4 byte
           Int64 i64=4;     // 8 byte

           uint ui=2;       // 4 byte
           long l=2;        // 8 byte
           ulong ul=2;      // 8 byte

           float f=5;       // 4 byte reel
           double d=5;      // 8 byte reel
           decimal de=5;    // 16 byte reel

           char ch='2';      // 2 byte
           string str="ali KIZILDAŞ"; //sınırsız
           bool b1= true;   // 1 bit
           bool b2= false;     // 1 bit

           DateTime dt=DateTime.Now;
           Console.WriteLine(dt);

           object o1="x";
           object o2='y';
           object o3=4;
           object o4=4.3;

           //string ifadeler

           string str1=string.Empty;
           str1="Ali KIZILDAŞ";
           string ad="Ali";
           string soyad="KIZILDAŞ";
           string tamAd=ad+ " "+soyad;

           //Değişken dönüşümleri
           string str20="20";
           int int20=20;
           string yeniDeger= str20+int20.ToString();

           Console.WriteLine(yeniDeger); // çıktısı 2020

           int int21= int20+Convert.ToInt32(str20);

           Console.WriteLine(int21); //çıktısı 40

           int int22=int20+int.Parse(str20);

           Console.WriteLine(int22); //çıktısı 40

           string datetime1= DateTime.Now.ToString("dd.MM.yyyy");
           Console.WriteLine(datetime1);

           string datetime3= DateTime.Now.ToString("dd/MM/yy");
           
           Console.WriteLine(datetime3);

           string hour=DateTime.Now.ToString("HH:mm");
           Console.WriteLine(hour);





        }
    }
}