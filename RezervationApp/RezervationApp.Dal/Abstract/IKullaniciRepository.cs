﻿using RezervationApp.Core.Data;
using RezervationApp.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezervationApp.Dal.Abstract
{
  public  interface IKullaniciRepository:IRepository<Kullanici,int,RezervationContext>
    {
    }
}
