using System.ComponentModel.DataAnnotations;

namespace CartTask.Core.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
