using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular",
                Local = "SP",
                Lote = "1° lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto1.png"
            },
            new Evento(){
                EventoId = 2,
                Tema = "React",
                Local = "RJ",
                Lote = "2° lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                ImagemURL = "foto2.png"
            }
           };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetBuyId(int id)
        {
           return _evento.Where(evento => evento.EventoId ==id);
        }

        [HttpPost]
        public string Post()
        {
           return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return "Post";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return "Post";
        }
        
    }
}
