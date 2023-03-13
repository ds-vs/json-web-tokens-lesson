using FacilitiesAPI.DAL.Repository;
using FacilitiesAPI.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacilitiesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TankController : BaseController<TankEntity, TankRepository>
    {
        public TankController(TankRepository repository) : base(repository) { }
    }
}
