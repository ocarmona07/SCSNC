namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para la Incidencia
    /// </summary>
    public class IncidenciasDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public IncidenciasDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea una Incidencia
        /// </summary>
        /// <param name="incidencia">Datos de la Incidencia</param>
        /// <returns>Id de confirmación</returns>
        public int CrearIncidencia(Incidencias incidencia)
        {
            try
            {
                _modulOtecEntities.Incidencias.Add(incidencia);
                return _modulOtecEntities.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que obtiene todas las Incidencias
        /// </summary>
        /// <returns>Listado de Incidencias</returns>
        public List<Incidencias> ObtenerIncidencias()
        {
            try
            {
                return _modulOtecEntities.Incidencias.ToList();
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
        /// Método que obtiene una Incidencia por su Id
        /// </summary>
        /// <param name="idIncidencia">Id de la Incidencia</param>
        /// <returns>Incidencia</returns>
        public Incidencias ObtenerIncidencia(int idIncidencia)
        {
            try
            {
                return _modulOtecEntities.Incidencias.Single(o => idIncidencia.Equals(o.IdIncidencia));
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
        /// Método que actualiza una Incidencia
        /// </summary>
        /// <param name="incidencia">Datos de la Incidencia</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarIncidencia(Incidencias incidencia)
        {
            try
            {
                var original = _modulOtecEntities.Incidencias.Find(incidencia.IdIncidencia);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(incidencia);
                return _modulOtecEntities.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }

        /// <summary>
        /// Método que elimina una Incidencia
        /// </summary>
        /// <param name="idIncidencia">Id de la Incidencia</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarIncidencia(int idIncidencia)
        {
            try
            {
                var entidad = _modulOtecEntities.Incidencias.Find(idIncidencia);
                if (entidad == null) return 0;
                _modulOtecEntities.Incidencias.Remove(entidad);
                return _modulOtecEntities.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                _modulOtecEntities.Dispose();
            }
        }
    }
}
