using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin_0306181111.Models
{
    public class CategoryModel
    {
       [Key]
        public int IDCategory { get; set; }
        public string Name { get; set; }
        public ICollection<PostModel> listPost { get; set; }
    }
}
