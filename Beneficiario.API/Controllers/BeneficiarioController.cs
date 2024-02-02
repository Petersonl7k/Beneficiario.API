using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Beneficiario.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly IBeneficiarioService _beneficiarioService;
        public BeneficiarioController(IBeneficiarioService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }
        [HttpGet]
        [Route("GetAsync")]
        public async Task<IEnumerable<BeneficiarioCommand>> GetAsync()
        {
            return await _beneficiarioService.GetAsync();
        }
        [HttpPost]
        [Route("PostAsync")]
        public async Task<string> PostAsync([FromBody] BeneficiarioCommand command)
        {
            return await _beneficiarioService.PostAsync(command);
        }
        [HttpPut]
        [Route("UpdateAsync")]
        public async Task<string> UpdateAsync([FromBody] BeneficiarioCommand command)
        {
            return await _beneficiarioService.UpdateAsync(command);
        }
        [HttpPut]
        [Route("DeleteAsync")]
        public async Task<string> DeleteAsync(string email)
        {
            return await _beneficiarioService.DeleteAsync(email);
        }
    }
}
