using Stock_API.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Stock_API.Controllers
{
    public class UsuarioComboController : ApiController
    {        
        [HttpGet]
        public JsonResult<List<OpcionCombo>> Get()
        {
            //SAF_RESPONSABLE_BIENPATRIMONIO_GetCbo
            var resultadoConsulta = new SAFEntities().SEC_USUARIO_GetCbo();

            List<OpcionCombo> opciones = new List<OpcionCombo>();

            foreach( var opcion in resultadoConsulta)
            {
                opciones.Add(new OpcionCombo
                {
                    Descripcion = opcion.ApeNom,
                    Id = opcion.IdUsuario
                });
            }

            return Json(opciones);
        }
    }
}