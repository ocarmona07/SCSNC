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
        /// <summary>
        /// Método que obtiene un listado de regiones
        /// </summary>
        /// <returns>Lista de Regiones</returns>
        public List<Regiones> ObtenerRegiones()
        {
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
                return new GeneralDa().ObtenerProvincias().Where(o => idRegion.Equals(o.IdRegion)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un lista de provincias por región
        /// </summary>
        /// <param name="idProvincia">Id de la Provincia</param>
        /// <returns>Lista de Provincias</returns>
        public List<Comunas> ObtenerComunasPorProvincia(int idProvincia)
        {
            try
            {
                return new GeneralDa().ObtenerComunas().Where(o => idProvincia.Equals(o.IdProvincia)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
