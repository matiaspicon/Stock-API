using Stock_API.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Stock_API.Controllers
{
    public class UnidadComboController : ApiController
    {
        [HttpGet]
        public JsonResult<List<OpcionCombo>> Get()
        {
            //SAF_RESPONSABLE_BIENPATRIMONIO_GetCbo
            var resultadoConsulta = new SAFEntities().SAF_UNIDAD_GetCbo_IdResponsable();

            List<OpcionCombo> opciones = new List<OpcionCombo>();

            foreach (var opcion in resultadoConsulta)
            {
                opciones.Add(new OpcionCombo
                {
                    Descripcion = opcion.Nombre,
                    Id = opcion.IdUnidad
                });
            }

            return Json(opciones);
        }
    }
}
