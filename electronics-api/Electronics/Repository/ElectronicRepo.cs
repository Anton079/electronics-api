using AutoMapper;
using electronics_api.Electronics.Dtos;
using electronics_api.Electronics.Models;
using electronics_api.Data.Migrations;
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

        public async Task<ElectronicResponse> CreateElectronicsAsync(ElectronicRequest electronicReq)
        {
            Electronic electronic = _mapper.Map<Electronic>(electronicReq);

            _appdbContext.Electronics.Add(electronic);

            await _appdbContext.SaveChangesAsync();

            ElectronicResponse response = _mapper.Map<ElectronicResponse>(electronic);

            return response;
        }

        public async Task<List<Electronic>> GetElectronicsAsync()
        {
            return await _appdbContext.Electronics.ToListAsync();
        }
    }
}
