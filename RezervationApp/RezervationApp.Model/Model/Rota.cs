using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RezervationApp.Model.Model
{
    public class Rota:Base,IEntity
    {
        public int KalkisId { get; set; }
        public int VarisId { get; set; }

        //navigation properties
        [ForeignKey("KalkisId")]
        public virtual Sehir KalkisSehri { get; set; }
        [ForeignKey("VarisId")]
        public virtual Sehir VarisSehri { get; set; }

    }
}
