using API_Biblioteca.Contracts.Services;
using API_Biblioteca.Response.Leitor;
using Microsoft.AspNetCore.Mvc;

namespace API_Biblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeitorController : ControllerBase
    {
        private ILeitorService _service;

        public LeitorController(ILeitorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<LeitorGetAllResponse>> Get()
        {
            return Ok(await _service.GetAll());
        }

    }
}
