using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebApiVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesControllerV2 : ControllerBase
    {
        // GET: api/<ValuesControllerV2>
        [HttpGet]
        public IEnumerable<Value> Get()
        {
            return new Value[] {
               new Value { Id = Guid.NewGuid(), Result = "value1"},
               new Value { Id = Guid.NewGuid(), Result = "value2"},
               new Value { Id = Guid.NewGuid(), Result = "value3"},
              };
        }
    }
}
