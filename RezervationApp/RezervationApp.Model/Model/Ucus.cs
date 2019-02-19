using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RezervationApp.Model.Model
{
    public class Ucus : Base, IEntity
    {
        public int RotaId { get; set; }
        [DataType(DataType.Date)]
        public DateTime UcusTarihi { get; set; }
        [DataType(DataType.Time)]
        public DateTime KalkisSaati { get; set; }
        [DataType(DataType.Duration)]
        public DateTime UcusSuresi { get; set; }
        public double BusinessFiyat { get; set; }
        public double EcoFiyat { get; set; }

        //navigation property
        [ForeignKey("RotaId")]
        public virtual Rota RotaBilgisi { get; set; }
    }
}
