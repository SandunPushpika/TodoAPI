using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApplication.Models {
    public class ApplicationUser {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string AddressNo { get; set; }
        [MaxLength(20)]
        public string Street { get; set; }
        [MaxLength(20)]
        public string City { get; set; }

    }
}
