using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class GrtraModel
    {
        //start 6 เจ้าหนี้การค้า // 

        public string grtra_empcod { get; set; }
        public string grtra_empname { get; set; }
        public string grtra_punumber { get; set; }
        public DateTime grtra_trndate { get; set; }
        public string grtra_trnqty { get; set; }
        public string grtra_trnprnet { get; set; }
        public string apprice_apqty { get; set; }
        public string apprice_apprice { get; set; }

    }

}