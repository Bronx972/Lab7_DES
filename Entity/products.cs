using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class products
    {
        public int product_id {  get; set; }

      
        public string name { get; set; }

        public decimal price { get; set; }

   
        public int stock { get; set; }

        public bool active { get; set; }
    }
}
