using AutoMapper;
using electronics_api.Data.Migrations;
using electronics_api.Electronics.Models;
using Microsoft.EntityFrameworkCore;


namespace electronics_api.Electronics.Repository
{
    public class ElectronicRepo:IElectronicRepo
    {
        private readonly AppDbContext _appdbContext;
        private readonly IMapper _mapper;

        public ElectronicRepo(AppDbContext appdbContext, IMapper mapper)
        {
            this._appdbContext = appdbContext;
            this._mapper = mapper;
        }

        public async Task<List<Electronic>> GetElectronicsAsync()
        {
            return await _appdbContext.Electronics.ToListAsync();
        }
    }
}
