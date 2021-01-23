using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //individual
    class GercekMusteri: Musteri   // miras = inheritance (musteride olan özellikler artık gerçekte de tüzelde de vardır demektir.)
    {
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
