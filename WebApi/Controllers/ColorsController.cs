using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _service;

        public ColorsController(IColorService service)
        {
            _service = service;
        }

        [HttpPost("add")]
        public void Add(Color color)
        {
            _service.Add(color);
        }
    }
}
