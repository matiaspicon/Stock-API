using Stock_API.Models;
using System.Web.Http;
using System.Linq;

namespace Stock_API.Controllers
{
    public class LoteController : ApiController
    {
        // GET: Lote
        public bool Post([FromBody] Lote lote)
        {

            //SAF_RESPONSABLE_BIENPATRIMONIO_GetCbo
            var resultadoConsulta = new SAFEntities().SAF_UNIDAD_GetCbo_IdResponsable();

            var idResponsable = resultadoConsulta.ToArray().FirstOrDefault(a => a.IdUnidad == lote.IdUnidad).idResponsableBien;

            foreach (var bien in lote.BienesID)
            {
                new SAFEntities().SAF_BIENPATRIMONIO_Upd_EXTERNO1(bien, 1, lote.IdUnidad, idResponsable, idResponsable);                
            }

            return true;
        }
    }
}