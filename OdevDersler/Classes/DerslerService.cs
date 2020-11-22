using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevDersler.Classes
{
    class DerslerService
    {
        readonly IIslemler _islem;
        public DerslerService(IIslemler ıslemler)
        {
           _islem=ıslemler;
        }
        public List<Ders> List()
        {
           return _islem.GetDersler();
            
        }
        public void AddDers(Ders ders)
        {
            _islem.AddD(ders);
        }

        
    }
}
