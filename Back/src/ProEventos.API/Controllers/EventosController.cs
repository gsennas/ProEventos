using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        { 
            return _context.Eventos.ToList(); 
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        { 
            return  _context.Eventos.FirstOrDefault(c=> c.EventoId.Equals(id)); 
        }

         [HttpPost]
        public Evento Post(Evento evento)
        {
            return evento;
        }

        [HttpPut]
        public string Put(int id)
        {
            return $"Value Post: {id}";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return $"Value Post: {id}";
        }
    }
}