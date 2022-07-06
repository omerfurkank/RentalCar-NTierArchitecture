using Business.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _service;

        public CarsController(ICarService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public List<GetCarDto> GetAll()
        {
            return _service.GetAllDetails();
        }
        [HttpPost("add")]
        public void Add(Car car)
        {
            _service.Add(car);
        }
    }
}
