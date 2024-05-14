using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Vezne
    {
        public string No { get; set; }
        public Personel Personel { get; set; }
        public Musteri Musteri { get; set; }

        VezneDurumu vezneDurumu;
        public VezneDurumu VezneDurumu {
            get { return vezneDurumu; }
            set {
                vezneDurumu = value;
                if (value == VezneDurumu.Musait)
                {
                    
                    VezneMusait?.Invoke(this, new EventArgs());
                   
                }
            }
        }

        public override string ToString()
        {
            return $"Vezne {No} {VezneDurumu} Personel=>{Personel}  Musteri=>{Musteri}";
        }

        public event EventHandler VezneMusait;
    }
}
