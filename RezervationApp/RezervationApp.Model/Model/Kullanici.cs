using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RezervationApp.Model.Model
{
    public class Kullanici:Base,IEntity
    {
        public Kullanici()
        {
            KullanicininBiletleri = new HashSet<Bilet>();
        }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Sifre { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        public virtual ICollection<Bilet> KullanicininBiletleri { get; set; }
    }
}
