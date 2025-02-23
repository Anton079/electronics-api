using electronics_api.Electronics.Dtos;
using electronics_api.Electronics.Models;
using electronics_api.Electronics.Repository;
using Microsoft.AspNetCore.Mvc;

namespace electronics_api.Electronics.ElectronicController
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
            var electronics = await _electronicRepo.GetElectronicsAsync();


            return Ok(electronics);
        }

        [HttpPost("Add")]

        public async Task<ActionResult<ElectronicResponse>> CreateAsync([FromBody]ElectronicRequest electronicReq)
        {
            ElectronicResponse eletronicSaved = await _electronicRepo.CreateElectronicsAsync(electronicReq);

            return Ok(eletronicSaved);
        }

    }
}
