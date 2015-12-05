namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase general para acceso a datos
    /// </summary>
    public class GeneralDa
    {
        /// <summary>
        /// Entidades del módulo
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que inicializa las entidades
        /// </summary>
        public GeneralDa()
        {
            if (_modulOtecEntities == null) _modulOtecEntities = new ModulOTECEntities();
        }

        #region Regiones

        /// <summary>
        /// Método que obtiene un lista de Regiones
        /// </summary>
        /// <returns>Lista de Regiones</returns>
        public List<Regiones> ObtenerRegiones()
        {
            try
            {
                return _modulOtecEntities.Regiones.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un lista de Provincias
        /// </summary>
        /// <returns>Lista de Provincias</returns>
        public List<Provincias> ObtenerProvincias()
        {
            try
            {
                return _modulOtecEntities.Provincias.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un lista de Comunas
        /// </summary>
        /// <returns>Lista de Comunas</returns>
        public List<Comunas> ObtenerComunas()
        {
            try
            {
                return _modulOtecEntities.Comunas.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        #endregion
        
        #region Roles

        /// <summary>
        /// Método que obtiene un lista de Roles
        /// </summary>
        /// <returns>Lista de Roles</returns>
        public List<Roles> ObtenerRoles()
        {
            try
            {
                return _modulOtecEntities.Roles.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un lista de Roles de Acceso
        /// </summary>
        /// <returns>Lista de Roles de Acceso</returns>
        public List<RolAcceso> ObtenerRolesAcceso()
        {
            try
            {
                return _modulOtecEntities.RolAcceso.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un lista de Accesos
        /// </summary>
        /// <returns>Lista de Roles</returns>
        public List<Accesos> ObtenerAccesos()
        {
            try
            {
                return _modulOtecEntities.Accesos.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        #endregion
        
        /// <summary>
        /// Método que obtiene un listado de Estados de una Incidencia
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<EstadosIncidencia> ObtenerEstadosIncidencias()
        {
            try
            {
                return _modulOtecEntities.EstadosIncidencia.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un lista de Tratamientos
        /// </summary>
        /// <returns>Lista de Tratamientos</returns>
        public List<Tratamientos> ObtenerTratamientos()
        {
            try
            {
                return _modulOtecEntities.Tratamientos.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un lista de Estados de Acciones
        /// </summary>
        /// <returns>Lista de Estados</returns>
        public List<EstadosAccion> ObtenerEstadosAccion()
        {
            try
            {
                return _modulOtecEntities.EstadosAccion.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene una lista de Modos de Detecciones
        /// </summary>
        /// <returns>Lista de Detecciones</returns>
        public List<ModosDeteccion> ObtenerModosDetecciones()
        {
            try
            {
                return _modulOtecEntities.ModosDeteccion.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene un listado de Tipos de Incidencias
        /// </summary>
        /// <returns>Lista de Tipos</returns>
        public List<TiposIncidencias> ObtenerTiposIncidencias()
        {
            try
            {
                return _modulOtecEntities.TiposIncidencias.ToList();
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }
    }
}
