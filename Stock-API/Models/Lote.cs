using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stock_API.Controllers
{
    public class Lote
    {
        [Key]
        public int Id { get; set; }
        public string IdResponsable { get; set; }
        public string IdUnidad { get; set; }
        public List<string> BienesID { get; set; }

    }
}