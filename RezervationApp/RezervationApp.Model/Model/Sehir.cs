using RezervationApp.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RezervationApp.Model.Model
{
    public class Sehir :Base, IEntity
    { 
        [Required]
        public string Ad { get; set; }
    }
}
