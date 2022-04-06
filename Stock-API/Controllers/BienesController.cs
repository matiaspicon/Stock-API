using Stock_API.Models;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Web.Http;
using System.Linq;


namespace Stock_API.Controllers
{
    public class BienesController : ApiController
    {
        public BienPatrimonio Get(int id)
        {
            //peticion a base de datos SP: [dbo].[SAF_BIENPATRIMONIO_GetById]
           
            ObjectResult<SAF_BIENPATRIMONIO_GetById_Result> bienEncontrado = new SAFEntities().SAF_BIENPATRIMONIO_GetById(id, null);

            var bien = bienEncontrado.ToArray()[0];

            var bienConvertido = new BienPatrimonio()
            {
                IdBienPatrimonio = bien.IdBienPatrimonio,
                IdResponsable = bien.IdResponsable,
                IdSecretariaGeneral = bien.IdSecretariaGeneral,
                IdUnidad = bien.IdUnidad,
                IdUsuarioACargo = bien.IdUsuarioACargo,
                PatCantidad = bien.PatCantidad,
                Clasificacion = bien.Clasificacion,
                Nombre = bien.nombre,
                PatDescrip = bien.PatDescrip,
                PatFoto = bien.PatFoto,
                PatUbicacion = bien.PatUbicacion
            };
            return bienConvertido;
        }


        public List<BienPatrimonio> Get([FromBody] List<int> ids)
        {
            List<BienPatrimonio> bienes = new List<BienPatrimonio>();

            foreach (var id in ids)
            {
                ObjectResult<SAF_BIENPATRIMONIO_GetById_Result> bienEncontrado = new SAFEntities().SAF_BIENPATRIMONIO_GetById(id, null);

                var bien = bienEncontrado.ToArray()[0];

                bienes.Add(new BienPatrimonio()
                {
                    IdBienPatrimonio = bien.IdBienPatrimonio,
                    IdResponsable = bien.IdResponsable,
                    IdSecretariaGeneral = bien.IdSecretariaGeneral,
                    IdUnidad = bien.IdUnidad,
                    IdUsuarioACargo = bien.IdUsuarioACargo,
                    PatCantidad = bien.PatCantidad,
                    Clasificacion = bien.Clasificacion,
                    Nombre = bien.nombre,
                    PatDescrip = bien.PatDescrip,
                    PatFoto = bien.PatFoto,
                    PatUbicacion = bien.PatUbicacion                    
                });
            }


            return bienes;
        }
    }
}
