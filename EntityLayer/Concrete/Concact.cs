using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Concact

    {
        [Key]
        public int ContactID { get; set; }
        public string ConcatUsername { get; set; }
        public string ConcatMail { get; set; }
        public string ConcatSubjet { get; set; }
        public string ConcatMessage { get; set; }
        public DateTime ConcatDate { get; set; }
        public bool ConcatStatus { get; set; }
    }
}
