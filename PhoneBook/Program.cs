using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persons person1 = new Persons("Şafak", "Akın", "05418166122");
            Persons person2 = new Persons("Mariam", "Murgulia", "05328166123");
            Persons person3 = new Persons("Gökhan", "Işık", "05338166124");
            Persons person4 = new Persons("Zozan", "Aktürk", "05348166125");
            Persons person5 = new Persons("Onur", "Ay", "05358166126");

            List<Persons> users = new List<Persons>();

            users.AddRange(new List<Persons>() { person1, person2, person3, person4, person5 });

            bool degisken = true;

            while (degisken == true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("****************************************************");
                Console.WriteLine("(1) Yeni numara kaydetmek.");
                Console.WriteLine("(2) Var olan numarayı silmek.");
                Console.WriteLine("(3) Var olan numarayı güncellemek.");
                Console.WriteLine("(4) Rehberi listelemek.");
                Console.WriteLine("(5) Rehberde arama yapmak.");
                Console.WriteLine("(6) Çıkış.");
                Console.WriteLine("****************************************************");

                string secim = "0";

                while (secim != "1" && secim != "2" && secim != "3" && secim != "4" && secim != "5" && secim != "6")
                {
                    secim = Console.ReadLine();
                    if (secim != "1" && secim != "2" && secim != "3" && secim != "4" && secim != "5" && secim != "6")
                    {
                        Console.WriteLine("Lütfen uygun bir değer giriniz.");
                    }

                }

                switch (secim)
                {
                    case "1":
                        Console.Write("Lütfen isim giriniz             :");
                        var _name = Console.ReadLine();
                        Console.Write("Lütfen soyisim giriniz          :");
                        var _surname = Console.ReadLine();
                        Console.Write("Lütfen telefon numarası giriniz :");
                        var _phoneNumber = Console.ReadLine();
                        var newPerson = new Persons(_name, _surname, _phoneNumber);
                        users.Add(newPerson);
                        break;

                    case "2":

                        int kisiSayisi = users.Count;

                        int secim4 = 2;

                        while (secim4 == 2)
                        {
                            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                            string aranan = Console.ReadLine();

                            string secim2 = "";

                            foreach (var item in users)
                            {

                                if (item.Name.Contains(aranan) || item.Surname.Contains(aranan))
                                {
                                    Console.WriteLine("İsim: {0}", item.Name);
                                    Console.WriteLine("Soyisim: {0}", item.Surname);
                                    Console.WriteLine("Telefon numarası: {0}", item.PhoneNumber);
                                    Console.WriteLine("Yukarıda bilgileri gösterilen kişi rehberden silinmek üzere, onaylıyor musunuz ? (y / n)", aranan);

                                    secim2 = Console.ReadLine();

                                    if (secim2 == "y")
                                    {
                                        users.Remove(item);
                                        Console.WriteLine("{0} {1} kişisi rehberden silindi", item.Name, item.Surname);
                                        Console.WriteLine("****************************************************");
                                        break;
                                    }
                                    else if (secim2 == "n")
                                    {
                                        Console.WriteLine("Telefon rehberinde herhangi bir güncelleme yapılmadı");
                                        Console.WriteLine("****************************************************");
                                        break;
                                    }
                                }
                            }
                            if (secim2 == "n" || secim2 == "y")
                            {
                                break;
                            }

                            if (kisiSayisi == users.Count)
                            {
                                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("Yeniden denemek için : (2)");
                                secim4 = int.Parse(Console.ReadLine());
                                if (secim4 == 1)
                                {
                                    break;
                                }
                            }
                        }

                        break;

                    case "3":

                        int secim5 = 2;

                        while (secim5 == 2)
                        {
                            Console.WriteLine("Lütfen bilgilerini güncellemek istediğiniz kişinin adını ve soyadını giriniz:");
                            Console.Write("İsim :");
                            string arananİsim = Console.ReadLine();
                            Console.Write("Soyisim :");
                            string arananSoyisim = Console.ReadLine();

                            string secim2 = "";

                            foreach (var item in users)
                            {
                                while (item.Name == arananİsim && item.Surname == arananSoyisim)
                                {
                                    Console.WriteLine("{0} {1} kişisi güncellenmek üzere, onaylıyor musunuz ? (y / n)", item.Name, item.Surname);

                                    secim2 = Console.ReadLine();

                                    while (secim2 != "y" && secim2 != "n")
                                    {
                                        Console.WriteLine("Lütfen 'y' veya 'n' seçeneklerinden birini giriniz");
                                        secim2 = Console.ReadLine();
                                        if (secim2 == "y" && secim2 == "n")
                                        {
                                            break;
                                        }
                                    }

                                    if (secim2 == "y")
                                    {
                                        Console.Write("Lütfen isim giriniz             :");
                                        item.Name = Console.ReadLine();
                                        Console.Write("Lütfen soyisim giriniz          :");
                                        item.Surname = Console.ReadLine();
                                        Console.Write("Lütfen telefon numarası giriniz :");
                                        item.PhoneNumber = Console.ReadLine();
                                        Console.WriteLine("Kişi güncellemesi tamamlandı");
                                        Console.WriteLine("****************************************************");
                                        break;
                                    }
                                    else if (secim2 == "n")
                                    {
                                        Console.WriteLine("Telefon rehberinde herhangi bir güncelleme yapılmadı");
                                        Console.WriteLine("****************************************************");
                                        break;
                                    }

                                }
                            }

                            if (secim2 == "n" || secim2 == "y")
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                                Console.WriteLine("Yeniden denemek için : (2)");
                                secim5 = int.Parse(Console.ReadLine());
                                if (secim5 == 1)
                                {
                                    break;
                                }
                            }
                        }
                        break;

                    case "4":

                        string listeTipi = "0";

                        Console.WriteLine("Lütfen görüntülemek istediğiniz liste tipini seçiniz");
                        Console.WriteLine("(1) İsimlerin başharflerine göre A-Z şeklinde");
                        Console.WriteLine("(2) İsimlerin başharflerine göre Z-A şeklinde");


                        while (listeTipi != "1" && listeTipi != "2")
                        {
                            listeTipi = Console.ReadLine();
                            if (listeTipi != "1" && listeTipi != "2")
                            {
                                Console.WriteLine("Lütfen uygun bir değer giriniz.");
                            }

                        }

                        switch (listeTipi)
                        {
                            case "1":
                                Console.WriteLine("Telefon rehberi A-Z");
                                Console.WriteLine("****************************************************");

                                users.Sort((x, y) => string.Compare(x.Name, y.Name));

                                foreach (var item in users)
                                {

                                    Console.WriteLine("İsim: {0}", item.Name);
                                    Console.WriteLine("Soyisim: {0}", item.Surname);
                                    Console.WriteLine("Telefon numarası: {0}", item.PhoneNumber);
                                    Console.WriteLine("****************************************************");
                                }
                                break;

                            case "2":
                                Console.WriteLine("Telefon rehberi Z-A");
                                Console.WriteLine("****************************************************");

                                users.Sort((x, y) => string.Compare(x.Name, y.Name));
                                users.Reverse();

                                foreach (var item in users)
                                {

                                    Console.WriteLine("İsim: {0}", item.Name);
                                    Console.WriteLine("Soyisim: {0}", item.Surname);
                                    Console.WriteLine("Telefon numarası: {0}", item.PhoneNumber);
                                    Console.WriteLine("****************************************************");
                                }
                                break;
                        }

                        break;

                    case "5":
                        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
                        Console.WriteLine("****************************************************");
                        Console.WriteLine("                                  ");
                        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                        int secim3 = int.Parse(Console.ReadLine());

                        switch (secim3)
                        {
                            case 1:
                                Console.WriteLine("Lütfen aradığınız kişinin isim veya soyismini giriniz");
                                string aranan2 = Console.ReadLine();


                                for (int i = 0; i < users.Count; i++)
                                {
                                    if (users[i].Name.Contains(aranan2) || users[i].Surname.Contains(aranan2))
                                    {
                                        Console.WriteLine("İsim: {0}", users[i].Name);
                                        Console.WriteLine("Soyisim: {0}", users[i].Surname);
                                        Console.WriteLine("Telefon numarası: {0}", users[i].PhoneNumber);
                                        Console.WriteLine("-");
                                    }
                                }

                                break;

                            case 2:
                                Console.WriteLine("Lütfen aradığınız kişinin telefon numarasını giriniz");
                                string aranan3 = Console.ReadLine();

                                for (int i = 0; i < users.Count; i++)
                                {
                                    if (users[i].PhoneNumber.Contains(aranan3))
                                    {
                                        Console.WriteLine("İsim: {0}", users[i].Name);
                                        Console.WriteLine("Soyisim: {0}", users[i].Surname);
                                        Console.WriteLine("Telefon numarası: {0}", users[i].PhoneNumber);
                                        Console.WriteLine("-");
                                    }
                                }
                                break;

                        }
                        break;

                    case "6":
                        degisken = false;
                        Console.WriteLine("****************************************************");
                        Console.WriteLine("Programdan çıkılıyor.");
                        Console.WriteLine("Tekrar görüşmek üzere.");
                        break;
                }

            }
            Console.ReadLine();

        }

    }
}
