using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogdulich.Web.Models.Category
{
    public class CreateCatgegory
    {
        [Display(Name ="Category Name")]
        [Required(ErrorMessage ="Category Name is required.")]
        public string CategoryName { get; set; }
    }
}
