using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Sınıf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamaltın = 100;
            int soforunaltını = 0;
            Random random = new Random();
            Liste liste = new Liste();
            for (int i = 0; i < 40; i++)//bağlı listeye eleman ekleme
            {
                liste.Elemanekleme();

            }
            Koltuk temp = liste.head;
            Koltuk temp1 = liste.head;
            Koltuk temp2 = liste.head;
            Koltuk temp4 = liste.head;



            for (int i = 0; i < 40; i++)//koltuklara numara verme
            {
                temp2.koltukno = i + 1;
                temp2 = temp2.sonraki;

            }

            while (toplamaltın > 0)
            {
                while (temp.sonraki != liste.tail && temp.sonraki != null && toplamaltın > 0)
                {
                    int altınsayısı3 = random.Next(1, 6);
                    if (altınsayısı3 > toplamaltın)
                    {
                        temp.altınsayısı = toplamaltın + temp.altınsayısı;
                        Console.WriteLine(temp.koltukno + ". koltuğa verilmeye çalışılan altın:" + altınsayısı3);
                        Console.WriteLine(temp.koltukno + ". koltuğa verilen altın sayısı:" + temp.altınsayısı);
                        toplamaltın = 0;


                    }
                    else
                    {
                        Console.WriteLine(temp.koltukno + ". koltuğa verilen altın:" + altınsayısı3);
                        temp.altınsayısı = altınsayısı3 + temp.altınsayısı;
                        Console.WriteLine(temp.koltukno + ". koltuğun altın sayısı :" + temp.altınsayısı);
                        temp = temp.sonraki;
                        temp.altınsayısı = 0 + temp.altınsayısı;
                        temp = temp.sonraki;
                        toplamaltın = toplamaltın - altınsayısı3;
                    }



                }
                Console.WriteLine("toplam altın sayısı" + toplamaltın);


                while (temp.sonraki == liste.tail && toplamaltın > 0)
                {
                    int altınsayısı2 = random.Next(1, 6);
                    if (altınsayısı2 > toplamaltın)
                    {
                        temp.altınsayısı = toplamaltın + temp.altınsayısı;

                        Console.WriteLine(temp.koltukno + ". koltuğa verilmeye çalışılan altın:" + altınsayısı2);
                        Console.WriteLine(temp.koltukno + ". koltuğun altın sayısı:" + temp.altınsayısı);
                        toplamaltın = 0;


                    }
                    else
                    {
                        Console.WriteLine(temp.koltukno + ". koltuğa verilen altın:" + altınsayısı2);
                        temp.altınsayısı = altınsayısı2 + temp.altınsayısı;
                        Console.WriteLine(temp.koltukno + ". koltuğun altın sayısı:" + temp.altınsayısı);
                        temp = temp.sonraki;
                        toplamaltın = toplamaltın - altınsayısı2;
                    }
                }
                Console.WriteLine("toplam altın sayısı" + toplamaltın);




                while (temp.onceki != liste.head && toplamaltın > 0)
                {
                    int altınsayısı1 = random.Next(1, 6);
                    if (altınsayısı1 > toplamaltın)
                    {
                        temp.altınsayısı = toplamaltın + temp.altınsayısı;

                        Console.WriteLine(temp.koltukno + ". koltuğa verilmeye çalışılan altın:" + altınsayısı1);
                        Console.WriteLine(temp.koltukno + ". koltuğun altın sayısı:" + temp.altınsayısı);
                        toplamaltın = 0;


                    }
                    else
                    {
                        Console.WriteLine(temp.koltukno + ". koltuğa verilen altın:" + altınsayısı1);
                        temp.altınsayısı = altınsayısı1 + temp.altınsayısı;
                        Console.WriteLine("koltuğun altın sayısı sona geldi:" + temp.altınsayısı);
                        temp = temp.onceki;
                        temp.altınsayısı = 0 + temp.altınsayısı;
                        temp = temp.onceki;
                        toplamaltın = toplamaltın - altınsayısı1;
                    }

                }

                Console.WriteLine("toplam altın sayısı" + toplamaltın);

                while (temp.onceki == liste.head && toplamaltın > 0)
                {
                    int altınsayısı = random.Next(1, 6);
                    if (altınsayısı > toplamaltın)
                    {
                        temp.altınsayısı = toplamaltın + temp.altınsayısı;
                        Console.WriteLine(temp.koltukno + ". koltuğa verilmeye çalışılan altın:" + altınsayısı);
                        Console.WriteLine(temp.koltukno + ". koltuğun altın sayısı:" + temp.altınsayısı);
                        toplamaltın = 0;


                    }
                    else
                    {
                        Console.WriteLine(temp.koltukno + ". koltuğa verilen altın:" + altınsayısı);
                        temp.altınsayısı = altınsayısı + temp.altınsayısı;
                        Console.WriteLine(temp.koltukno + ". koltuğun altın sayısı :" + temp.altınsayısı);
                        temp = temp.onceki;
                        toplamaltın = toplamaltın - altınsayısı;
                    }


                }
                Console.WriteLine("toplam altın sayısı" + toplamaltın);



            }


            List<string> adliste = new List<string>();
            List<int> koltuksec = new List<int>();
            List<string> cinsiyetliste = new List<string>();
            Console.WriteLine("yedisi bayan sekizi erkek olmaz üzere yolcuların isimlerini giriniz");
            int kadıntoplam = 0;
            int erkektoplam = 0;





            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("isimlerini giriniz");
                string yolcuad = Console.ReadLine();
                Console.WriteLine("cinsiyetinini giriniz");
                string yolcucinsiyet = Console.ReadLine();
                adliste.Add(yolcuad);
                cinsiyetliste.Add(yolcucinsiyet);

            }
            for (int i = 0; i < 40; i++)
            {
                koltuksec.Add(i + 1);
            }
            for (int i = 0; i < 15; i++)
            {
                Koltuk temp3 = liste.head;

                int number = random.Next(0, koltuksec.Count);
                int number1 = koltuksec[number];
                while (temp3.koltukno != number1)
                {
                    temp3 = temp3.sonraki;
                }
                temp3.name = adliste[i];
                temp3.cinsiyet = cinsiyetliste[i];
                Console.WriteLine("yolcu :{0} -koltuk numarası:{1} - altın sayısı:{2} ", temp3.name, temp3.koltukno, temp3.altınsayısı);
                koltuksec.RemoveAt(number);
            }

            for (int i = 0; i < 40; i++)
            {
                if (temp4.cinsiyet == "kadın")
                {
                    kadıntoplam = kadıntoplam + temp4.altınsayısı;
                }
                else if (temp4.cinsiyet == "erkek")
                {
                    erkektoplam = erkektoplam + temp4.altınsayısı;
                }
                temp4 = temp4.sonraki;

            }

            for (int i = 0; i < 40; i++)
            {
                if (temp1.name == null)
                {
                    soforunaltını = soforunaltını + temp1.altınsayısı;
                }
                temp1 = temp1.sonraki;
            }
            Console.WriteLine("şöförün altınları:" + soforunaltını);
            Console.WriteLine("kadınların altınları:" + kadıntoplam);
            Console.WriteLine("erkeklerin altınları:" + erkektoplam);

            Console.ReadKey();



        }
    }
    public class Koltuk
    {
        public string name;
        public int altınsayısı;
        public int koltukno;
        public string cinsiyet;
        public Koltuk sonraki;
        public Koltuk onceki;
        public Koltuk()
        {


            sonraki = null;
            onceki = null;
        }
    }
    public class Liste
    {
        public Koltuk head;
        public Koltuk tail;
        public Liste()
        {
            head = null;
            tail = null;
        }
        public void Elemanekleme()
        {
            Koltuk koltuk = new Koltuk();
            if (head == null)
            {
                head = tail = koltuk;
            }
            else
            {


                tail.sonraki = koltuk;
                koltuk.onceki = tail;
                tail = koltuk;
            }
        }
        void KisiyiYerlestir()
        {

        }
    }
}