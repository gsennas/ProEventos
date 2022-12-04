using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        List<Evento> _listaEventos = new List<Evento>(){
                new Evento(){
                EventoId = 1,
                Tema = "Angular 11",
                Local = "Belo Horizonte",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Lote = "1",
                ImagemUrl = "teste1.jpg"
            },
            new Evento(){
                EventoId = 2,
                Tema = "CSS",
                Local = "Rio de Janeiro",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.ToString(),
                Lote = "2",
                ImagemUrl = "teste2.jpg"}
                };

        public EventosController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        { 
            return _listaEventos; 
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        { 
            return _listaEventos.Where(c=> c.EventoId.Equals(id)).FirstOrDefault(); 
        }

         [HttpPost]
        public string Post()
        {
            _listaEventos.Add(
            new Evento(){
                EventoId = 3,
                Tema = "CSS",
                Local = "Rio de Janeiro",
                QuantidadePessoas = 250,
                DataEvento = DateTime.Now.ToString(),
                Lote = "2",
                ImagemUrl = "teste2.jpg"
                });
                if(_listaEventos.Where(c=> c.EventoId.Equals(3)).Any())
                return "Sucesso";

                return "Erro";
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