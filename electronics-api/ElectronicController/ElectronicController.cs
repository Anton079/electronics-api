using electronics_api.Electronics.Models;
using electronics_api.Electronics.Repository;
using Microsoft.AspNetCore.Mvc;

namespace electronics_api.ElectronicRepo
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ElectronicController : ControllerBase
    {
        private IElectronicRepo _electronicRepo;

        public ElectronicController(IElectronicRepo electronicRepo)
        {
            _electronicRepo = electronicRepo;
        }

        [HttpGet("all")]

        public async Task<ActionResult<List<Electronic>>> GetELectronicsAsync()
        {
            var electronic = await _electronicRepo.GetElectronicsAsync();


            return Ok(electronic);
        }

    }
}
