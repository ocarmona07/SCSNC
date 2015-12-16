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
        /// Método que obtiene un lista de provincias
        /// </summary>
        /// <returns>Lista de Provincias</returns>
        public List<Provincias> ObtenerProvincias()
        {
            Text = "Provincia";
            Value = "IdProvincia";
            return new GeneralDa().ObtenerProvincias();
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
        /// Método que obtiene un lista de comunas
        /// </summary>
        /// <returns>Lista de Comunas</returns>
        public List<Comunas> ObtenerComunas()
        {
            Text = "Comuna";
            Value = "IdComuna";
            return new GeneralDa().ObtenerComunas();
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
        /// Método que obtiene un rol por su ID
        /// </summary>
        /// <param name="idRol">Id del Rol</param>
        /// <returns>Rol</returns>
        public Roles ObtenerRol(int idRol)
        {
            return new GeneralDa().ObtenerRoles().First(r => idRol.Equals(r.IdRol));
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

        #region Obtiene entidad por Id

        /// <summary>
        /// Método que obtiene el estado de una incidencia
        /// </summary>
        /// <param name="idEstado">Id Estado Incidencia</param>
        /// <returns>Estados de Incidencia</returns>
        public EstadosIncidencia ObtenerEstadoIncidencia(int idEstado)
        {
            try
            {
                Text = "Descripcion";
                Value = "IdEstadoIncidencia";
                return new GeneralDa().ObtenerEstadosIncidencias().First(o => idEstado.Equals(o.IdEstadoIncidencia));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un Tratamiento
        /// </summary>
        /// <param name="idTratamiento">Id Tratamiento</param>
        /// <returns>Tratamiento</returns>
        public Tratamientos ObtenerTratamiento(int idTratamiento)
        {
            try
            {
                Text = "Descripcion";
                Value = "IdTratamiento";
                return new GeneralDa().ObtenerTratamientos().First(o => idTratamiento.Equals(o.IdTratamiento));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un Estado de Acción
        /// </summary>
        /// <param name="idEstado">Id Estado Acción</param>
        /// <returns>Estado Acción</returns>
        public EstadosAccion ObtenerEstadoAccion(int idEstado)
        {
            try
            {
                Text = "Descripcion";
                Value = "IdEstado";
                return new GeneralDa().ObtenerEstadosAccion().First(o => idEstado.Equals(o.IdEstado));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un Modo de Detección
        /// </summary>
        /// <param name="idModo">Id Modo Detección</param>
        /// <returns>Modo de Detección</returns>
        public ModosDeteccion ObtenerModoDeteccion(int idModo)
        {
            try
            {
                Text = "Descripcion";
                Value = "IdModoDeteccion";
                return new GeneralDa().ObtenerModosDetecciones().First(o => idModo.Equals(o.IdModoDeteccion));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un Tipo de Incidencia
        /// </summary>
        /// <param name="idTipo">Id Tipo de Incidencia</param>
        /// <returns>Tipo de Incidencia</returns>
        public TiposIncidencias ObtenerTipoIncidencia(int idTipo)
        {
            try
            {
                Text = "Descripcion";
                Value = "IdTipoIncidencia";
                return new GeneralDa().ObtenerTiposIncidencias().First(o => idTipo.Equals(o.IdTipoIncidencia));
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion

        #region Varios

        /// <summary>
        /// Método que valida un RUT
        /// </summary>
        /// <param name="rut">RUT</param>
        /// <returns>Respuesta de validación</returns>
        public bool ValidarRut(string rut)
        {
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                var rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                var dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                return dv == (char)(s != 0 ? s + 47 : 75);
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
