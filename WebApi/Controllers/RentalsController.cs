using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _service;

        public RentalsController(IRentalService service)
        {
            _service = service;
        }

        [HttpPost("add")]
        public void Add(Rental rental)
        {
            _service.Add(rental);
        }
    }
}
