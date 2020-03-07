using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers.Services
{
    public class KorisniciService : IKorisniciService
    {
        protected eProdajaContext _context;
        protected IMapper _mapper;

        public KorisniciService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<Model.Request.Korisnici> GetAll()
        {
            var entities = _context.Korisnici.ToList();
            //IList<Model.Request.Korisnici> result = new List<Model.Request.Korisnici>();

            //entities.ForEach(x => result.Add(new Model.Request.Korisnici
            //{
            //    Email = x.Email,
            //    Ime = x.Ime,
            //    KorisnickoIme = x.KorisnickoIme,
            //    KorisnikId = x.KorisnikId,
            //    Prezime = x.Prezime,
            //    Status = x.Status,
            //    Telefon = x.Telefon
            //}));

            var result = _mapper.Map<IList<Model.Request.Korisnici>>(entities);

            return result;
        }

        public Model.Korisnici GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Model.Korisnici Insert(KorisniciInsertRequest korisnik)
        {
            var entity = new Model.Korisnici
            {
                Email = korisnik.Email,
                Ime = korisnik.Ime,
                LozinkaHash = korisnik.LozinkaHash,
                Prezime = korisnik.Prezime,
                LozinkaSalt = korisnik.LozinkaSalt,
                Telefon = korisnik.Telefon,
                Status = korisnik.Status,
                KorisnickoIme = korisnik.KorisnickoIme
            };

            _context.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public Model.Korisnici Update(int id, Model.Korisnici korisnik)
        {
            throw new NotImplementedException();
        }
    }
}
