using electronics_api.Electronics.Models;

namespace electronics_api.Electronics.Repository
{
    public interface IElectronicRepo
    {
        Task<List<Electronic>> GetElectronicsAsync();
    }
}
