using Beneficiario.Domain.Commands;
using Beneficiario.Domain.Interface;

namespace Beneficiario.Service.Service
{
    public class BeneficiarioService : IBeneficiarioService
    {
        private readonly IBeneficiarioRepository _repository;
        public BeneficiarioService(IBeneficiarioRepository repository)
        {
            _repository = repository;
        }
        public Task<IEnumerable<BeneficiarioCommand>> GetAsync()
        {
            return _repository.GetAsync();
        }
        public Task<string> PostAsync(BeneficiarioCommand command)
        {
            return _repository.PostAsync(command);
        }
        public Task<string> UpdateAsync(BeneficiarioCommand command)
        {
            return _repository.UpdateAsync(command);
        }
        public Task<string> DeleteAsync(string email)
        {
            return _repository.DeleteAsync(email);
        }
    }
}
