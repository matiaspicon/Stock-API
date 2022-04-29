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
        public BienPatrimonio Get(String id)
        {
            //peticion a base de datos, ejecuta SP: [dbo].[SAF_BIENPATRIMONIO_GetById]           
            ObjectResult<SAF_BIENPATRIMONIO_GetById_Result> bienEncontrado = new SAFEntities().SAF_BIENPATRIMONIO_GetById(int.Parse(id), null);
            var bienesArray = bienEncontrado.ToArray();

            //setear valores por defecto si no se encuentra
            BienPatrimonio bienConvertido = new BienPatrimonio()
            {
                IdBienPatrimonio = "0",
                IdResponsable = 0,
                PatDescrip = "Bien no encontrado"
            };

            if (bienesArray.Length > 0)
            {
                //guarda el primer resultado
                var bien = bienesArray[0];

                //crea el objeto para la respuesta
                bienConvertido = new BienPatrimonio()
                {
                    IdBienPatrimonio = bien.IdBienPatrimonio.ToString(),
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
            }
            //retorna el valor buscado
            return bienConvertido;
        }


        public List<BienPatrimonio> Post([FromBody] List<String> ids)
        {
            List<BienPatrimonio> bienes = new List<BienPatrimonio>();

            foreach (var id in ids)
            {
                ObjectResult<SAF_BIENPATRIMONIO_GetById_Result> bienEncontrado = new SAFEntities().SAF_BIENPATRIMONIO_GetById(int.Parse(id), null);
                               
                var bienesArray = bienEncontrado.ToArray();

                if (bienesArray.Length > 0)
                {
                    var bien = bienesArray[0];

                    bienes.Add(new BienPatrimonio()
                    {
                        IdBienPatrimonio = bien.IdBienPatrimonio.ToString(),
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
                else
                {
                    //devolver objeto vacio
                    bienes.Add(new BienPatrimonio()
                    {
                        IdBienPatrimonio = id,
                        PatDescrip = "Bien no encontrado"
                    });
                }
            }

            return bienes;
        }
    }
}
