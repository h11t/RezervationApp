using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RezervationApp.Model.Model
{
    public class Bilet : Base, IEntity
    {
        public int KullaniciId { get; set; }
        public int UcusId { get; set; }

        public double Fiyat { get; set; }

        //navigation properties
        
        [ForeignKey("UcusId")]
        public virtual  Ucus UcusBilgisi { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanici { get; set; }
    }
}
