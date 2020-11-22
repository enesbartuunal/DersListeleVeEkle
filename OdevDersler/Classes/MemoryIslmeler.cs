using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevDersler.Classes
{
    class MemoryIslmeler : IIslemler
    {
        public static List<Ders> dersler = new List<Ders>()
            {
                new Ders()
                {
                Id = 1,
                adi = "Matematik",
                dersKategori = DersKategoriEnum.Sayısal,
                icerik = "Çok eğlenceli dört işlemler...",
                dersKredisi = DersKredisiEnum.Bes
                },
                new Ders()
                {
                Id = 2,
                adi = "Fizik",
                dersKategori = DersKategoriEnum.Sayısal,
                icerik = "Maddenin Eylemsizlik Kanunu...",
                dersKredisi = DersKredisiEnum.Dort
                },
                new Ders()
                {
                Id = 3,
                adi = "Türkçe",
                dersKategori = DersKategoriEnum.Sozel,
                icerik = "Büyük ve küçük ünlü uyumu...",
                dersKredisi = DersKredisiEnum.Uc
                },
                new Ders()
                {
                Id = 4,
                adi = "Coğrafya",
                dersKategori = DersKategoriEnum.Sozel,
                icerik = "Coğrafi İklimler...",
                dersKredisi = DersKredisiEnum.Iki
                },
                new Ders()
                {
                Id = 5,
                adi = "Kimya",
                dersKategori = DersKategoriEnum.Sayısal,
                icerik = "Pamukta Fasülye Yapımı...",
                dersKredisi = DersKredisiEnum.Bir
                }
            };
        public void AddD(Ders ders)
        {
            dersler.Add(ders);
            
        }

        public List<Ders> GetDersler()
        {
            return dersler;
        }
    }
}
