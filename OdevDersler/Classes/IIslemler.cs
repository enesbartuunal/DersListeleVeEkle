using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevDersler.Classes
{
    interface IIslemler
    {
        List<Ders> GetDersler();//Dersleri Listteler.

        void AddD(Ders ders);//Listeye Ders Ekler.  
    }
}
