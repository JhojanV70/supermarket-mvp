﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Par mode name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Product Price")]
        [Required(ErrorMessage = "Product price is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Product Price must be between 1 and 50 characters")]
        public int Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product stock is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Product Stock must be between 1 and 50 characters")]
        public int Stock { get; set; }
    }
}
