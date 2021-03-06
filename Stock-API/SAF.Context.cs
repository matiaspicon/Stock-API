//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock_API
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class SAFEntities : DbContext
    {
        public SAFEntities()
            : base("name=SAFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SAF_BIENPATRIMONIO> SAF_BIENPATRIMONIO { get; set; }
    
        public virtual ObjectResult<SAF_BIENPATRIMONIO_GetAll_Result> SAF_BIENPATRIMONIO_GetAll(Nullable<int> idBienPatrimonio, Nullable<int> idTipo, string nombre, Nullable<System.DateTime> fechaDesde, Nullable<System.DateTime> fechaHasta, Nullable<int> idUnidad, Nullable<int> idEstado, Nullable<int> idResponsable, Nullable<int> idInciso, Nullable<int> idPartidaPrincipal, Nullable<int> idPartidaParcial, Nullable<int> idClase, Nullable<int> idItem, Nullable<short> idOrigen, Nullable<short> etiqueta, string idSecretariaGeneral, Nullable<System.DateTime> fechaAltaDesde, Nullable<System.DateTime> fechaAltaHasta, Nullable<bool> ubicado)
        {
            var idBienPatrimonioParameter = idBienPatrimonio.HasValue ?
                new ObjectParameter("IdBienPatrimonio", idBienPatrimonio) :
                new ObjectParameter("IdBienPatrimonio", typeof(int));
    
            var idTipoParameter = idTipo.HasValue ?
                new ObjectParameter("IdTipo", idTipo) :
                new ObjectParameter("IdTipo", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaDesdeParameter = fechaDesde.HasValue ?
                new ObjectParameter("FechaDesde", fechaDesde) :
                new ObjectParameter("FechaDesde", typeof(System.DateTime));
    
            var fechaHastaParameter = fechaHasta.HasValue ?
                new ObjectParameter("FechaHasta", fechaHasta) :
                new ObjectParameter("FechaHasta", typeof(System.DateTime));
    
            var idUnidadParameter = idUnidad.HasValue ?
                new ObjectParameter("IdUnidad", idUnidad) :
                new ObjectParameter("IdUnidad", typeof(int));
    
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            var idResponsableParameter = idResponsable.HasValue ?
                new ObjectParameter("IdResponsable", idResponsable) :
                new ObjectParameter("IdResponsable", typeof(int));
    
            var idIncisoParameter = idInciso.HasValue ?
                new ObjectParameter("IdInciso", idInciso) :
                new ObjectParameter("IdInciso", typeof(int));
    
            var idPartidaPrincipalParameter = idPartidaPrincipal.HasValue ?
                new ObjectParameter("IdPartidaPrincipal", idPartidaPrincipal) :
                new ObjectParameter("IdPartidaPrincipal", typeof(int));
    
            var idPartidaParcialParameter = idPartidaParcial.HasValue ?
                new ObjectParameter("IdPartidaParcial", idPartidaParcial) :
                new ObjectParameter("IdPartidaParcial", typeof(int));
    
            var idClaseParameter = idClase.HasValue ?
                new ObjectParameter("IdClase", idClase) :
                new ObjectParameter("IdClase", typeof(int));
    
            var idItemParameter = idItem.HasValue ?
                new ObjectParameter("IdItem", idItem) :
                new ObjectParameter("IdItem", typeof(int));
    
            var idOrigenParameter = idOrigen.HasValue ?
                new ObjectParameter("IdOrigen", idOrigen) :
                new ObjectParameter("IdOrigen", typeof(short));
    
            var etiquetaParameter = etiqueta.HasValue ?
                new ObjectParameter("Etiqueta", etiqueta) :
                new ObjectParameter("Etiqueta", typeof(short));
    
            var idSecretariaGeneralParameter = idSecretariaGeneral != null ?
                new ObjectParameter("IdSecretariaGeneral", idSecretariaGeneral) :
                new ObjectParameter("IdSecretariaGeneral", typeof(string));
    
            var fechaAltaDesdeParameter = fechaAltaDesde.HasValue ?
                new ObjectParameter("FechaAltaDesde", fechaAltaDesde) :
                new ObjectParameter("FechaAltaDesde", typeof(System.DateTime));
    
            var fechaAltaHastaParameter = fechaAltaHasta.HasValue ?
                new ObjectParameter("FechaAltaHasta", fechaAltaHasta) :
                new ObjectParameter("FechaAltaHasta", typeof(System.DateTime));
    
            var ubicadoParameter = ubicado.HasValue ?
                new ObjectParameter("Ubicado", ubicado) :
                new ObjectParameter("Ubicado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SAF_BIENPATRIMONIO_GetAll_Result>("SAF_BIENPATRIMONIO_GetAll", idBienPatrimonioParameter, idTipoParameter, nombreParameter, fechaDesdeParameter, fechaHastaParameter, idUnidadParameter, idEstadoParameter, idResponsableParameter, idIncisoParameter, idPartidaPrincipalParameter, idPartidaParcialParameter, idClaseParameter, idItemParameter, idOrigenParameter, etiquetaParameter, idSecretariaGeneralParameter, fechaAltaDesdeParameter, fechaAltaHastaParameter, ubicadoParameter);
        }
    
        public virtual ObjectResult<SAF_BIENPATRIMONIO_GetAllResponsablesPatrimoniales_Result> SAF_BIENPATRIMONIO_GetAllResponsablesPatrimoniales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SAF_BIENPATRIMONIO_GetAllResponsablesPatrimoniales_Result>("SAF_BIENPATRIMONIO_GetAllResponsablesPatrimoniales");
        }
    
        public virtual ObjectResult<SAF_BIENPATRIMONIO_GetById_Result> SAF_BIENPATRIMONIO_GetById(Nullable<int> idBienPatrimonio, Nullable<int> idBienPatrimoniohasta)
        {
            var idBienPatrimonioParameter = idBienPatrimonio.HasValue ?
                new ObjectParameter("IdBienPatrimonio", idBienPatrimonio) :
                new ObjectParameter("IdBienPatrimonio", typeof(int));
    
            var idBienPatrimoniohastaParameter = idBienPatrimoniohasta.HasValue ?
                new ObjectParameter("IdBienPatrimoniohasta", idBienPatrimoniohasta) :
                new ObjectParameter("IdBienPatrimoniohasta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SAF_BIENPATRIMONIO_GetById_Result>("SAF_BIENPATRIMONIO_GetById", idBienPatrimonioParameter, idBienPatrimoniohastaParameter);
        }
    
        public virtual int SAF_BIENPATRIMONIO_Upd(Nullable<int> idBienPatrimonio, string patDescrip, Nullable<int> idTipo, Nullable<int> idEstado, Nullable<int> idUnidad, Nullable<System.DateTime> patFechaUnidad, string idSecretariaGeneral, Nullable<int> idResponsable, Nullable<int> patCantidad, string patUbicacion, string patFoto, Nullable<short> idInciso, Nullable<short> idPartidaPrincipal, Nullable<short> idPartidaParcial, Nullable<short> idClase, Nullable<short> idItem, Nullable<decimal> precio, Nullable<short> idOrigen, Nullable<int> idUsuario, Nullable<int> periodoAmortiz, Nullable<int> inicioAmortiz, Nullable<int> idClasificacion, Nullable<int> idMotivoBaja, Nullable<bool> devengado, Nullable<bool> fisicoContable, Nullable<int> idBienUsoGenerico, Nullable<System.DateTime> patFechaBaja, Nullable<int> mesInicioAmortiz, Nullable<int> idUsuarioACargo, Nullable<short> partes)
        {
            var idBienPatrimonioParameter = idBienPatrimonio.HasValue ?
                new ObjectParameter("IdBienPatrimonio", idBienPatrimonio) :
                new ObjectParameter("IdBienPatrimonio", typeof(int));
    
            var patDescripParameter = patDescrip != null ?
                new ObjectParameter("PatDescrip", patDescrip) :
                new ObjectParameter("PatDescrip", typeof(string));
    
            var idTipoParameter = idTipo.HasValue ?
                new ObjectParameter("IdTipo", idTipo) :
                new ObjectParameter("IdTipo", typeof(int));
    
            var idEstadoParameter = idEstado.HasValue ?
                new ObjectParameter("IdEstado", idEstado) :
                new ObjectParameter("IdEstado", typeof(int));
    
            var idUnidadParameter = idUnidad.HasValue ?
                new ObjectParameter("IdUnidad", idUnidad) :
                new ObjectParameter("IdUnidad", typeof(int));
    
            var patFechaUnidadParameter = patFechaUnidad.HasValue ?
                new ObjectParameter("PatFechaUnidad", patFechaUnidad) :
                new ObjectParameter("PatFechaUnidad", typeof(System.DateTime));
    
            var idSecretariaGeneralParameter = idSecretariaGeneral != null ?
                new ObjectParameter("IdSecretariaGeneral", idSecretariaGeneral) :
                new ObjectParameter("IdSecretariaGeneral", typeof(string));
    
            var idResponsableParameter = idResponsable.HasValue ?
                new ObjectParameter("IdResponsable", idResponsable) :
                new ObjectParameter("IdResponsable", typeof(int));
    
            var patCantidadParameter = patCantidad.HasValue ?
                new ObjectParameter("PatCantidad", patCantidad) :
                new ObjectParameter("PatCantidad", typeof(int));
    
            var patUbicacionParameter = patUbicacion != null ?
                new ObjectParameter("PatUbicacion", patUbicacion) :
                new ObjectParameter("PatUbicacion", typeof(string));
    
            var patFotoParameter = patFoto != null ?
                new ObjectParameter("PatFoto", patFoto) :
                new ObjectParameter("PatFoto", typeof(string));
    
            var idIncisoParameter = idInciso.HasValue ?
                new ObjectParameter("IdInciso", idInciso) :
                new ObjectParameter("IdInciso", typeof(short));
    
            var idPartidaPrincipalParameter = idPartidaPrincipal.HasValue ?
                new ObjectParameter("IdPartidaPrincipal", idPartidaPrincipal) :
                new ObjectParameter("IdPartidaPrincipal", typeof(short));
    
            var idPartidaParcialParameter = idPartidaParcial.HasValue ?
                new ObjectParameter("IdPartidaParcial", idPartidaParcial) :
                new ObjectParameter("IdPartidaParcial", typeof(short));
    
            var idClaseParameter = idClase.HasValue ?
                new ObjectParameter("IdClase", idClase) :
                new ObjectParameter("IdClase", typeof(short));
    
            var idItemParameter = idItem.HasValue ?
                new ObjectParameter("IdItem", idItem) :
                new ObjectParameter("IdItem", typeof(short));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var idOrigenParameter = idOrigen.HasValue ?
                new ObjectParameter("IdOrigen", idOrigen) :
                new ObjectParameter("IdOrigen", typeof(short));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var periodoAmortizParameter = periodoAmortiz.HasValue ?
                new ObjectParameter("PeriodoAmortiz", periodoAmortiz) :
                new ObjectParameter("PeriodoAmortiz", typeof(int));
    
            var inicioAmortizParameter = inicioAmortiz.HasValue ?
                new ObjectParameter("InicioAmortiz", inicioAmortiz) :
                new ObjectParameter("InicioAmortiz", typeof(int));
    
            var idClasificacionParameter = idClasificacion.HasValue ?
                new ObjectParameter("IdClasificacion", idClasificacion) :
                new ObjectParameter("IdClasificacion", typeof(int));
    
            var idMotivoBajaParameter = idMotivoBaja.HasValue ?
                new ObjectParameter("IdMotivoBaja", idMotivoBaja) :
                new ObjectParameter("IdMotivoBaja", typeof(int));
    
            var devengadoParameter = devengado.HasValue ?
                new ObjectParameter("Devengado", devengado) :
                new ObjectParameter("Devengado", typeof(bool));
    
            var fisicoContableParameter = fisicoContable.HasValue ?
                new ObjectParameter("FisicoContable", fisicoContable) :
                new ObjectParameter("FisicoContable", typeof(bool));
    
            var idBienUsoGenericoParameter = idBienUsoGenerico.HasValue ?
                new ObjectParameter("IdBienUsoGenerico", idBienUsoGenerico) :
                new ObjectParameter("IdBienUsoGenerico", typeof(int));
    
            var patFechaBajaParameter = patFechaBaja.HasValue ?
                new ObjectParameter("PatFechaBaja", patFechaBaja) :
                new ObjectParameter("PatFechaBaja", typeof(System.DateTime));
    
            var mesInicioAmortizParameter = mesInicioAmortiz.HasValue ?
                new ObjectParameter("MesInicioAmortiz", mesInicioAmortiz) :
                new ObjectParameter("MesInicioAmortiz", typeof(int));
    
            var idUsuarioACargoParameter = idUsuarioACargo.HasValue ?
                new ObjectParameter("IdUsuarioACargo", idUsuarioACargo) :
                new ObjectParameter("IdUsuarioACargo", typeof(int));
    
            var partesParameter = partes.HasValue ?
                new ObjectParameter("Partes", partes) :
                new ObjectParameter("Partes", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SAF_BIENPATRIMONIO_Upd", idBienPatrimonioParameter, patDescripParameter, idTipoParameter, idEstadoParameter, idUnidadParameter, patFechaUnidadParameter, idSecretariaGeneralParameter, idResponsableParameter, patCantidadParameter, patUbicacionParameter, patFotoParameter, idIncisoParameter, idPartidaPrincipalParameter, idPartidaParcialParameter, idClaseParameter, idItemParameter, precioParameter, idOrigenParameter, idUsuarioParameter, periodoAmortizParameter, inicioAmortizParameter, idClasificacionParameter, idMotivoBajaParameter, devengadoParameter, fisicoContableParameter, idBienUsoGenericoParameter, patFechaBajaParameter, mesInicioAmortizParameter, idUsuarioACargoParameter, partesParameter);
        }
    
        public virtual ObjectResult<SAF_UNIDAD_GetCbo_IdResponsable_Result> SAF_UNIDAD_GetCbo_IdResponsable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SAF_UNIDAD_GetCbo_IdResponsable_Result>("SAF_UNIDAD_GetCbo_IdResponsable");
        }
    
        public virtual ObjectResult<SEC_USUARIO_GetCbo_Result> SEC_USUARIO_GetCbo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SEC_USUARIO_GetCbo_Result>("SEC_USUARIO_GetCbo");
        }
    
        public virtual int SAF_BIENPATRIMONIO_Upd_EXTERNO(Nullable<int> idBienPatrimonio, Nullable<int> idUsuario, Nullable<int> idUnidad, Nullable<int> idResponsable, Nullable<int> idUsuarioACargo)
        {
            var idBienPatrimonioParameter = idBienPatrimonio.HasValue ?
                new ObjectParameter("IdBienPatrimonio", idBienPatrimonio) :
                new ObjectParameter("IdBienPatrimonio", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idUnidadParameter = idUnidad.HasValue ?
                new ObjectParameter("IdUnidad", idUnidad) :
                new ObjectParameter("IdUnidad", typeof(int));
    
            var idResponsableParameter = idResponsable.HasValue ?
                new ObjectParameter("IdResponsable", idResponsable) :
                new ObjectParameter("IdResponsable", typeof(int));
    
            var idUsuarioACargoParameter = idUsuarioACargo.HasValue ?
                new ObjectParameter("IdUsuarioACargo", idUsuarioACargo) :
                new ObjectParameter("IdUsuarioACargo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SAF_BIENPATRIMONIO_Upd_EXTERNO", idBienPatrimonioParameter, idUsuarioParameter, idUnidadParameter, idResponsableParameter, idUsuarioACargoParameter);
        }
    }
}
