using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _service;

        public BrandsController(IBrandService service)
        {
            _service = service;
        }
        [HttpPost("add")]
        public void Add(Brand brand)
        {
            _service.Add(brand);
        }
    }
}
