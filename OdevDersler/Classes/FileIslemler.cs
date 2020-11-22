using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevDersler.Classes
{
    class FileIslemler : IIslemler
    {
       public static List<Ders> dersler2 = new List<Ders>();
       string path = Application.StartupPath.Replace(@"\bin\Debug", @"\Classes\Files") + @"\TextFile1.txt";



        public void AddD(Ders ders)
        {
            dersler2.Add(ders);



            //path = path.Replace(@"\bin\Debug", @"\Classes\File") + @"\TextFile1.txt";
            string line = "";
            
                line = "\n" + ders.Id + ";" + ders.adi + ";" + (int)ders.dersKategori + ";" + ders.icerik + ";" + (int)ders.dersKredisi ;
                File.AppendAllText(path,line);
            
        }

        public List<Ders> GetDersler()
        {
            try
            {
                Ders ders;
               

                //path = path.Replace(@"\bin\Debug", @"\Classes\File") + @"\TextFile1.txt";
                IEnumerable<string> linesDosya = File.ReadLines(path);
                foreach (var line  in linesDosya)
                {

                ders = new Ders();
                ders.Id = Convert.ToInt32(line.Split(';')[0]);
                ders.adi = line.Split(';')[1];
                ders.dersKategori = (DersKategoriEnum)Convert.ToInt32(line.Split(';')[2]);
                ders.icerik = line.Split(';')[3];
                ders.dersKredisi = (DersKredisiEnum)Convert.ToInt32(line.Split(';')[4]);
                dersler2.Add(ders);
                }
        
                return dersler2;

            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
                return null;
            };
        }
    }
}
