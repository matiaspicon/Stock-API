using Stock_API.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Stock_API.Controllers
{
    public class CombosController : ApiController
    {
        
        [HttpGet]
        [ActionName("Responsables")]
        public JsonResult<List<OpcionCombo>> Get()
        {

            //SAF_RESPONSABLE_BIENPATRIMONIO_GetCbo
            var a = new SAFEntities().SAF_BIENPATRIMONIO_GetAllResponsablesPatrimoniales();


            List<OpcionCombo> opciones = new List<OpcionCombo>();

            foreach( var opcion in a)
            {
                opciones.Add(new OpcionCombo
                {
                    Descripcion = opcion.ApeNom,
                    Id = opcion.idResponsable
                });
            }

            return Json(opciones);
        }
    }
}