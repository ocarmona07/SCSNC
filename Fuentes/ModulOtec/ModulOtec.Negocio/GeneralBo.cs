namespace ModulOtec.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Datos;

    /// <summary>
    /// Clase general de negocio
    /// </summary>
    public class GeneralBo
    {
        public string Text = "";
        public string Value = "";

        #region Regiones/Provincias/Comunas

        /// <summary>
        /// Método que obtiene un listado de regiones
        /// </summary>
        /// <returns>Lista de Regiones</returns>
        public List<Regiones> ObtenerRegiones()
        {
            Text = "Region";
            Value = "IdRegion";
            return new GeneralDa().ObtenerRegiones();
        }

        /// <summary>
        /// Método que obtiene un lista de provincias por región
        /// </summary>
        /// <param name="idRegion">Id de la Región</param>
        /// <returns>Lista de Provincias</returns>
        public List<Provincias> ObtenerProvinciasPorRegion(int idRegion)
        {
            try
            {
                Text = "Provincia";
                Value = "IdProvincia";
                return new GeneralDa().ObtenerProvincias().Where(o => idRegion.Equals(o.IdRegion)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un lista de comunas por provincia
        /// </summary>
        /// <param name="idProvincia">Id de la Provincia</param>
        /// <returns>Lista de Comunas</returns>
        public List<Comunas> ObtenerComunasPorProvincia(int idProvincia)
        {
            try
            {
                Text = "Comuna";
                Value = "IdComuna";
                return new GeneralDa().ObtenerComunas().Where(o => idProvincia.Equals(o.IdProvincia)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Roles

        /// <summary>
        /// Método que obtiene un listado de roles
        /// </summary>
        /// <returns>Lista de Roles</returns>
        public List<Roles> ObtenerRoles()
        {
            Text = "Descripcion";
            Value = "IdRol";
            return new GeneralDa().ObtenerRoles();
        }

        /// <summary>
        /// Método que valida si el usuario cumple con el rol
        /// </summary>
        /// <param name="rutUsuario">Rut del Usuario</param>
        /// <returns>Validación del usuario</returns>
        public bool ValidarRolUsuario(int rutUsuario)
        {
            var usuario = new UsuariosDa().ObtenerUsuario(rutUsuario);
            return usuario != null && new GeneralDa().ObtenerRoles().Exists(rol => usuario.IdRol.Equals(rol.IdRol));
        }

        #endregion

        #region Carga de Drop Down Lists

        /// <summary>
        /// Método que obtiene un listado de Estados de una Incidencia
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<EstadosIncidencia> ObtenerEstadosIncidencias()
        {
            Text = "Descripcion";
            Value = "IdEstadoIncidencia";
            return new GeneralDa().ObtenerEstadosIncidencias().Where(o => o.Estado).ToList();
        }

        /// <summary>
        /// Método que obtiene un lista de Tratamientos
        /// </summary>
        /// <returns>Lista de Tratamientos</returns>
        public List<Tratamientos> ObtenerTratamientos()
        {
            Text = "Descripcion";
            Value = "IdTratamiento";
            return new GeneralDa().ObtenerTratamientos().Where(o => o.Estado).ToList();
        }

        /// <summary>
        /// Método que obtiene un lista de Estados de Acciones
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<EstadosAccion> ObtenerEstadosAccion()
        {
            Text = "Descripcion";
            Value = "IdEstado";
            return new GeneralDa().ObtenerEstadosAccion().Where(o => o.Estado).ToList();
        }

        /// <summary>
        /// Método que obtiene una lista de Modos de Detecciones
        /// </summary>
        /// <returns>Lista de Detecciones</returns>
        public List<ModosDeteccion> ObtenerModosDetecciones()
        {
            Text = "Descripcion";
            Value = "IdModoDeteccion";
            return new GeneralDa().ObtenerModosDetecciones().Where(o => o.Estado).ToList();
        }

        /// <summary>
        /// Método que obtiene un listado de Tipos de Incidencias
        /// </summary>
        /// <returns>Lista de Tipos</returns>
        public List<TiposIncidencias> ObtenerTiposIncidencias()
        {
            Text = "Descripcion";
            Value = "IdTipoIncidencia";
            return new GeneralDa().ObtenerTiposIncidencias().Where(o => o.Estado).ToList();
        }

        #endregion
    }
}
