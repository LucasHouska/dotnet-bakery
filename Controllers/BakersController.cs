using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BakersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public BakersController(ApplicationContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Baker> GetAll() {
            //look ma no SQL
            return _context.Bakers;
        }

        [HttpGet("{id}")]
        public ActionResult<Baker> GetById(int id) {
            Baker baker = _context.Bakers
            .SingleOrDefault(baker => baker.id == id);

            if(baker == null) {
                return NotFound();
            }

            return baker;
        }

        [HttpPost]
        public Baker Post(Baker baker) {
            _context.Add(baker);
            _context.SaveChanges();

            return baker;
        }
    }
}
