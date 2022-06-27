using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            case 2:

            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string aranan = Console.ReadLine();

            int kisiSayisi = users.Count;

            int secim4 = 2;

            while (secim4 == 2)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].Name.Contains(aranan) || users[i].Surname.Contains(aranan))
                    {
                        Console.WriteLine("{0} isimli/soyisimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (y / n)", aranan);

                        string secim2 = Console.ReadLine();

                        if (secim2 == "y")
                        {
                            users.RemoveAt(i);
                        }
                        else if (secim2 == "n")
                        {
                            kisiSayisi++;
                        }
                        break;
                    }
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
        }
    }
}
