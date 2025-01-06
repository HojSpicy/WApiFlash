using System.Collections.Generic;
using System.Threading.Tasks;
using WApiFlash.Domain.Interfaces;
using WApiFlash.Domain.Models;

namespace WApiFlash.Application.Services
{
    public class FlashService
    {
        private readonly IGenericRepository<Flash> _repository;

        public FlashService(IGenericRepository<Flash> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Flash>> GetAllFlashesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Flash> GetFlashByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Flash> AddFlashAsync(Flash flash)
        {
            return await _repository.AddAsync(flash);
        }

        public async Task UpdateFlashAsync(Flash flash)
        {
            await _repository.UpdateAsync(flash);
        }

        public async Task DeleteFlashAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
