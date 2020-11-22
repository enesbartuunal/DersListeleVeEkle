using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevDersler.Classes
{
    class Ders
    {
        private int _Id;
        private string _Adi;
        private DersKategoriEnum _DersKategori;
        private string _Icerik;
        private DersKredisiEnum _DersKredisi;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        public string adi
        {
            get
            {
                return _Adi;
            }
            set
            {
                _Adi = value;
            }
        }
        public DersKategoriEnum dersKategori
        {
            get
            {
                return _DersKategori;
            }
            set
            {
                _DersKategori = value;
            }
        }
        public string icerik
        {
            get
            {
                return _Icerik;
            }
            set
            {
                _Icerik = value;
            }
        }
        public DersKredisiEnum dersKredisi
        {
            get
            {
                return _DersKredisi;
            }
            set
            {
                _DersKredisi = value;
            }
        }
    }
}
