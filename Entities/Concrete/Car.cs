
using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public  class Car:IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public int ColorId { get; set; }
        [ForeignKey("ColorId")]
        public Color Color { get; set; }
        public string ModelYear { get; set; }
        public float DailyPrice { get; set; }
        public string Description { get; set; }  
    }
}
