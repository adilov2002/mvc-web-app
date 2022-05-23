using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_web_app.Models {
    public class Anticafe {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        
        
    }
}