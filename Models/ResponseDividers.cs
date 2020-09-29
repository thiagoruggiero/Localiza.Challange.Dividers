using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Dividers.Models
{
    public class ResponseDividers
    {
        public ResponseDividers()
        {
            AllDividers = new List<int>();
            PrimeDividers = new List<int>();
        }

        public List<int> AllDividers { get; set; }
        public List<int> PrimeDividers { get; set; }
        [JsonIgnore]
        public bool FoundAnswer { get; set; }
    }
}
