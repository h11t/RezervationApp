using RezervationApp.Bll.Abstract;
using RezervationApp.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezervationApp.Bll.Concrete
{
    public class KullaniciManager : KullaniciRepository, IKullaniciService
    {
        public bool Inactivate(int id)
        {
            try
            {
                var userToBeInactivate = Get(x => x.Id == id);
                userToBeInactivate.IsDelete = true;
                return Update(userToBeInactivate);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
