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
        /// Método que obtiene un lista de regiones
        /// </summary>
        /// <returns></returns>
        public List<Regiones> ObtenerRegiones()
        {
            try
            {
                var listaRetorno = _modulOtecEntities.Regiones.ToList();
                _modulOtecEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un lista de ciudades
        /// </summary>
        /// <returns></returns>
        public List<Ciudades> ObtenerCiudades()
        {
            try
            {
                var listaRetorno = _modulOtecEntities.Ciudades.ToList();
                _modulOtecEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un lista de ciudades por región
        /// </summary>
        /// <returns></returns>
        public List<Ciudades> ObtenerCiudadesPorRegion(int idRegion)
        {
            try
            {
                var listaRetorno = _modulOtecEntities.Ciudades.Where(o => o.IdRegion == idRegion).ToList();
                _modulOtecEntities.Dispose();
                return listaRetorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
