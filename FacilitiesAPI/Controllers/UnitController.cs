using FacilitiesAPI.DAL.Repository;
using FacilitiesAPI.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FacilitiesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitController : BaseController<UnitEntity, UnitRepository>
    {
        public UnitController(UnitRepository repository) : base(repository) { }
    }
}
