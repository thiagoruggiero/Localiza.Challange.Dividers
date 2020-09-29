using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Dividers.Models
{
    public class NumberModel
    {
        public NumberModel()
        {
            Dividers = new ResponseDividers();
        }

        [Required]
        public int Number { get; set; }

        public ResponseDividers Dividers { get; set; }
    }
}
