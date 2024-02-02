using Beneficiario.Domain.Commands;

namespace Beneficiario.Domain.Interface
{
    public interface IBeneficiarioRepository
    {
        Task<IEnumerable<BeneficiarioCommand>> GetAsync();
        Task<string> PostAsync(BeneficiarioCommand command);
        Task<string> UpdateAsync(BeneficiarioCommand command);
        Task<string> DeleteAsync(string email);
    }
}
