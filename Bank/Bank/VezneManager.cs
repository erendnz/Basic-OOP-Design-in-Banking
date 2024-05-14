using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class VezneManager : IManagerIslemleri<Vezne>
    {
        private List<Vezne> _vezneler =new List<Vezne>();
        public void Ekle(Vezne entity)
        {
            _vezneler.Add(entity);
        }

        public List<Vezne> Listele()
        {
             
            return _vezneler;
            
        }

        public void IslemYap()
        {
            foreach(Vezne vezne in _vezneler)
            {
                if (vezne.VezneDurumu == VezneDurumu.Mesgul && vezne.Musteri !=null)
                {
                   //Thread.Sleep(vezne.Musteri.IslemTipi.Sure * 10);
                    vezne.VezneDurumu = VezneDurumu.Musait;
                }
            }
          

        }

       
    }
}
