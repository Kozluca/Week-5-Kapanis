using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Kapanis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> Carliste = new List<Car>();                         // Car sınıfından Lise oluşturduk
        Başla:
            Console.WriteLine("ARABA ÜRETMEK İSTER MİSİNİZ ?");
            string answer = Console.ReadLine();                                 //Kullanıcıdan cevap aldık
            answer = answer.ToLower();                                          //Kücük Harfe çevirdik
        Uret:
            if (answer == "h")                                                  // cevap h ise program kapatılacak
            {
                Console.WriteLine("Çıkış Yapılıyor...");

            }
            else if (answer == "e")                                             // cevap e ise araba bilgilerini kullanıcadan aldık
            {
                Console.WriteLine("Arabanın Markasını Girin.");
                string input2 = Console.ReadLine();
                Console.WriteLine("Arabanın Modelini Girin.");
                string input3 = Console.ReadLine();
                Console.WriteLine("Arabanın Rengini Girin.");
                string input4 = Console.ReadLine();
                Console.WriteLine("Arabanın Seri Numarasını Girin.");
                string input = Console.ReadLine();
            ORTA:
                try                   // Kapı sayısının yanlıs tipte girilmesi durumunda geriye hata verecek
                {
                    Console.WriteLine("Arabanın Kapı Sayısını Girin.");
                    int input5 = Convert.ToInt32(Console.ReadLine());
                    Carliste.Add(new Car(DateTime.Now, input, input2, input3, input4, input5));
                }
                catch               // hatalı giriş olursa catch çalısır , ve goto Komutunda ki yere gönderir programı
                {
                    Console.WriteLine("Hatalı veri girdiniz");
                    goto ORTA;
                }

                Console.WriteLine("------------------------");
               son:
                Console.WriteLine("Başka araba üretmek ister misiniz ?");
                string answer2 = Console.ReadLine();
                if (answer2 == "evet")
                {
                    goto Uret;
                }
                else if (answer2 == "hayır")
                {
                    Car.CarList(Carliste);
                }
                else
                {
                    Console.WriteLine("Hatalı cevap");
                    goto son;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz Cevap");
                goto Başla;
            }

            Console.ReadKey();
        }
    }
}
