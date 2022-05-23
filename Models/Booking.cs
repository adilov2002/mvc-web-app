using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_web_app.Models {
    public class Booking {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Anticafe")]
        public int AnticafeId { get; set; }
        public Anticafe Anticafe { get; set; }
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}