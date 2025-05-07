using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Enums;

namespace WebApplication1.Entities
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Transmissions { get; set; }

        [Column(TypeName = "text")]
        public string Type { get; set; }

        public string[] Comments { get; set; }
        public string image { get; set; }
        public string Capacity { get; set; }
        public string Fuel { get; set; }

    }
}
