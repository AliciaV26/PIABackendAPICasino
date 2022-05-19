using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPICasino.DTOs;
using WebAPICasino.Entidades;

namespace WebAPICasino.Controllers
{
    [ApiController]
    [Route("clientes")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]

    public class ClientesController : ControllerBase
    {

        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public ClientesController(ApplicationDbContext context, IMapper mapper)
        {
            this.dbContext = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetClienteDTO>>> Get()
        {
            var clientes = await dbContext.Clientes.ToListAsync();
            if (clientes == null)
            {
                return NotFound("No existen clientes registrados");
            }
        
            return mapper.Map<List<GetClienteDTO>>(clientes);
        }

        /*[HttpGet("{id:int}" , Name = "obtenerCliente")]
        public async Task<ActionResult<List<GetClienteDTO>>> Get([FromRoute] int id)
        {
            var clientes = await dbContext.Clientes.FirstOrDefaultAsync(clienteBD => clienteBD.Id == id);

            if (clientes == null)
            {
                return NotFound("No existe un cliente con ese ID");
            }

            return mapper.Map<List<GetClienteDTO>>(clientes);
        }*/


        [HttpGet("{nombre}")]
        public async Task<ActionResult<List<GetClienteDTO>>> Get([FromRoute] string nombre)
        {
            var clientes = await dbContext.Clientes.Where(clienteBD => clienteBD.Nombre.Contains(nombre)).ToListAsync();

            if (clientes == null)
            {
                return NotFound("No existen clientes con ese nombre");
            }

            return mapper.Map<List<GetClienteDTO>>(clientes);

        }

        // GET PARA OBTENER LAS RIFAS EN LAS QUE PARTICIPA UN CLIENTE (SE NECESITA TABLA CLIENTERIFA)

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClienteDTO clienteDto)
        {
            var existeClienteConEseNombre = await dbContext.Clientes.AnyAsync(x => x.Nombre == clienteDto.Nombre);

            if (existeClienteConEseNombre)
            {
                return BadRequest("Ya existe un cliente con el nombre {clienteDto.Nombre}");
            }
            
            var cliente = mapper.Map<Cliente>(clienteDto);

            dbContext.Add(cliente);
            await dbContext.SaveChangesAsync();

            var clienteDTO = mapper.Map<GetClienteDTO>(cliente);

            return Ok();

            //return CreatedAtRoute("obtenerCliente", new { id=cliente.Id}, clienteDTO);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(ClienteDTO clienteCreacionDTO, int id)
        {
            var exist = await dbContext.Clientes.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("No existe el ID ingresado");
            }

            var cliente = mapper.Map<Cliente>(clienteCreacionDTO);
            cliente.Id = id;

            dbContext.Update(cliente);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Clientes.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("No fue encontrado el cliente");
            }

            dbContext.Remove(new Cliente()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        

    }
}
