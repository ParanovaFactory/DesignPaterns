using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.EntityLayer.Concrate
{
    public class Category
    {
        [Key]
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
