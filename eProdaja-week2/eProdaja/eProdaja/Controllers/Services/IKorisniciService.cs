using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using eProdaja.Model;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model.Request;

namespace eProdaja.Controllers.Services
{
    public interface IKorisniciService
    {
        IList<Model.Request.Korisnici> GetAll();
        Model.Korisnici GetById(int id);
        Model.Korisnici Insert(KorisniciInsertRequest korisnik);
        Model.Korisnici Update(int id, Model.Korisnici korisnik);
    }
}
