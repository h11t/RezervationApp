using RezervationApp.Core.Data.EntityFramework;
using RezervationApp.Dal.Abstract;
using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezervationApp.Dal.Concrete
{
  public  class UcusRepository:EntityBaseRepository<Ucus,int,RezervationContext>,IUcusRepository
    {
    }
}
