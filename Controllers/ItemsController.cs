using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testRest1.Managers;
using testRest1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testRest1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsManager _manager = new ItemsManager();

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public Item Post([FromBody] Item value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public Item Put(int id, [FromBody] Item value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public Item Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
