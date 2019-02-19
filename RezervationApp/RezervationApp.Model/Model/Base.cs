using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RezervationApp.Model.Model
{
   public class Base:IEntity
    {
        [Key]
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [DefaultValue(false)]
        public bool IsDelete { get; set; }
    }
}
