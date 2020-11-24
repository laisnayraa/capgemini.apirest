using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIRestClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente() { Id = 1, Nome = "Carla", Sexo = "Feminino", Idade = 36, Contato = "(71) 8888-8888", Endereco = "Rua 123" });
            clientes.Add(new Cliente() { Id = 2, Nome = "Monaliza", Sexo = "Feminino", Idade = 25, Contato = "(71) 9999-9999", Endereco = "Rua 456" });
            clientes.Add(new Cliente() { Id = 3, Nome = "Fred", Sexo = "Masculino", Idade = 44, Contato = "(71) 0000-0000", Endereco = "Rua 789" });

            return clientes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Cliente>> Get(int id)
        {
            List < Cliente > clientes = new List<Cliente>();

            clientes.Add(new Cliente() { Id = 1, Nome = "Carla", Sexo = "Feminino", Idade = 36, Contato = "(71) 8888-8888", Endereco = "Rua 123" });
            clientes.Add(new Cliente() { Id = 2, Nome = "Monaliza", Sexo = "Feminino", Idade = 25, Contato = "(71) 9999-9999", Endereco = "Rua 456" });
            clientes.Add(new Cliente() { Id = 3, Nome = "Fred", Sexo = "Masculino", Idade = 44, Contato = "(71) 0000-0000", Endereco = "Rua 789" });

            return clientes.Where(_ => _.Id == id).ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente() { Id = 1, Nome = "Carla", Sexo = "Feminino", Idade = 36, Contato = "(71) 8888-8888", Endereco = "Rua 123" });
            clientes.Add(new Cliente() { Id = 2, Nome = "Monaliza", Sexo = "Feminino", Idade = 25, Contato = "(71) 9999-9999", Endereco = "Rua 456" });
            clientes.Add(new Cliente() { Id = 3, Nome = "Fred", Sexo = "Masculino", Idade = 44, Contato = "(71) 0000-0000", Endereco = "Rua 789" });
            
            clientes.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
