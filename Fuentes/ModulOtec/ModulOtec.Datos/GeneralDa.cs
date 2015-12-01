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
        /// Método que obtiene un lista de Ciudades
        /// </summary>
        /// <returns>Lista de Ciudades</returns>
        public List<Ciudades> ObtenerCiudades()
        {
            try
            {
                return _modulOtecEntities.Ciudades.ToList();
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
        public List<Tratamiento> ObtenerTratamientos()
        {
            try
            {
                return _modulOtecEntities.Tratamiento.ToList();
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
