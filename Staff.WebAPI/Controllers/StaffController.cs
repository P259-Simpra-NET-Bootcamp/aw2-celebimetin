using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Staff.Service.Schemas;
using Staff.Service.Services.Staff;
using Kadro = Staff.Data.Domains;

namespace Staff.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService service;
        private readonly IMapper mapper;

        public StaffController(IStaffService service, IMapper mapper)
        {
            this.mapper = mapper;
            this.service = service;
        }

        [HttpGet("GetAll")]
        public List<StaffResponse> GetAll()
        {
            var entites = service.GetAll();
            var mapped = mapper.Map<List<StaffResponse>>(entites);
            return mapped;
        }

        [HttpGet("GetByEmail")]
        public List<StaffResponse> GetByEmail(string email)
        {
            var listEmail = service.Where(x => x.Email == email);
            if (!listEmail.Any()) { throw new Exception($"{email} Email adresi bulunamadı."); }

            var mapped = mapper.Map<List<StaffResponse>>(listEmail);
            return mapped.ToList();
        }

        [HttpGet("GetByPhone")]
        public List<StaffResponse> GetByPhone(string phone)
        {
            var listPhone = service.Where(x => x.Phone == phone);
            if (!listPhone.Any()) { throw new Exception($"{phone} Telefon numarası bulunamadı."); }

            var mapped = mapper.Map<List<StaffResponse>>(listPhone);
            return mapped.ToList();
        }

        [HttpGet("{id}")]
        public StaffResponse GetById(int id)
        {
            var entity = service.GetById(id);
            var mapped = mapper.Map<StaffResponse>(entity);
            return mapped;
        }

        [HttpPost]
        public void Add([FromBody] StaffRequest request)
        {
            var entity = mapper.Map<Kadro.Staff>(request);
            var email = service.Where(x => x.Email == request.Email);
            if (email.Any())
                throw new Exception($"{request.Email} mail adresi kullanılmaktadır");
            service.Insert(entity);
        }

        [HttpPut("{id}")]
        public void Update([FromBody] StaffRequest request, int id)
        {
            request.Id = id;
            var entity = mapper.Map<Kadro.Staff>(request);
            service.Update(entity);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteEntity = service.Where(x => x.Id == id);
            if (deleteEntity == null && !deleteEntity.Equals(id)) { throw new Exception($"{id} Not Found!"); }
            service.Delete(id);
        }
    }
}