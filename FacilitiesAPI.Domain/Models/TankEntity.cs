using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilitiesAPI.Domain.Models
{
    public class TankEntity : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Volume { get; set; }
        public int? MaxVolume { get; set; }
        public UnitEntity? Unit { get; set; }
    }
}
