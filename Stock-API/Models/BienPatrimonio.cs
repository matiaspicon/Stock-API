using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock_API.Models
{
    public class BienPatrimonio
    {
        public string IdBienPatrimonio { get; set; }
        public string PatDescrip { get; set; }
        public int IdUnidad { get; set; }
        public string IdSecretariaGeneral { get; set; }
        public int IdResponsable { get; set; }
        public int PatCantidad { get; set; }
        public string PatUbicacion { get; set; }
        public string PatFoto { get; set; }
        public Nullable<int> IdUsuarioACargo { get; set; }
        public string Clasificacion { get; set; }
        public string Nombre { get; set; }

    }
}