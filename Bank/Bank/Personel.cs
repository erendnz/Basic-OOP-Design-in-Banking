using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Personel:Kisi
    {
        public double Maas { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" {Maas}";
        }
    }
}
