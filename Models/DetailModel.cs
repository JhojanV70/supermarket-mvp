using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class DetailModel
    {
        [DisplayName("Datail Id")]
        public int Id { get; set; }

        [DisplayName("Detail Qantity")]
        [Required(ErrorMessage = "Detail Quantity is Required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Detail quantity must be between 1 and  100 characters")]
        public string Quantity { set; get; }

        [DisplayName ("Detail Price")]
        [Required(ErrorMessage = "Detail Price is Required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Detail Price must be between 1 and 100 characters")]
        public string Price { set; get; }
    }
}
