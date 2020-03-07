using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers.Services;
using eProdaja.Model;
using eProdaja.Model.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        protected IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public IList<Model.Request.Korisnici> GetAll()
        {
            return _service.GetAll();
        }
        [HttpPost]
        public Model.Request.Korisnici Insert(KorisniciInsertRequest korisnik)
        {
            return null;
            //return _service.Insert(korisnik);
        }
    }
}