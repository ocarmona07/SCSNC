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
        /// <returns></returns>
        public List<Regiones> ObtenerRegiones()
        {
            return new GeneralDa().ObtenerRegiones();
        }

        /// <summary>
        /// Método que obtiene un listado de ciudades
        /// </summary>
        /// <returns></returns>
        public List<Ciudades> ObtenerCiudades()
        {
            return new GeneralDa().ObtenerCiudades();
        }

        /// <summary>
        /// Método que obtiene un lista de ciudades por región
        /// </summary>
        /// <returns></returns>
        public List<Ciudades> ObtenerCiudadesPorRegion(int idRegion)
        {
            try
            {
                return ObtenerCiudades().Where(o => idRegion.Equals(o.IdRegion)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
