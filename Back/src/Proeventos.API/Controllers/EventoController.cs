﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {



        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]        public IEnumerable<Evento> Get()
        {
           return _context.Eventos;
        }

        [HttpPost]
        public string Post()
        {
            return "cuzao do caramba";
        }

        [HttpPut("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                Evento => Evento.EventoId ==id
            );
        }

        [HttpPut("{id}")]
        public string Delete(int id)
        {
            return $"agora tem o Delete put id= {id}";
        }
    }
}
