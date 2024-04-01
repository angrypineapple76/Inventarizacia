using Inventarizacia.Model.BD;
using Inventarizacia.Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventarizacia.ViewModel
{
    public class VMAuth
    {
        public InventarzEntities entities = new InventarzEntities();
        public VMAuth(string Log,string Pas) 
        {
            Auth Auser = entities.Auth.Where(x=>x.Loggin==Log&&x.Passwordd==Pas).SingleOrDefault();
            Set.user = new User(Auser.ID, Auser.Loggin);
        }
    }
}
