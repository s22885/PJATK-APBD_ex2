using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IDBService _iDBService;
        public EventController(IDBService dBService)
        {
            _iDBService = dBService;
        }
        [HttpGet]
        public async Task<IActionResult> GetActionWithOrganisers(bool ContainsEndData)
        {
            var res = await _iDBService.GetEventWithOrganisers(ContainsEndData);
            return Ok(res);
        }
    }
}
