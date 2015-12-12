namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para el Analisis de la causa
    /// </summary>
    public class AnalisisCausasDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public AnalisisCausasDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea un Análisis de la Causa
        /// </summary>
        /// <param name="analisisCausa">Datos del Análisis de la Causa</param>
        /// <returns>Id de confirmación</returns>
        public int CrearAnalisisCausa(AnalisisCausa analisisCausa)
        {
            try
            {
                _modulOtecEntities.AnalisisCausa.Add(analisisCausa);
                _modulOtecEntities.SaveChanges();
                return analisisCausa.IdAnalisisCausa;
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
        /// Método que obtiene todos los Análisis
        /// </summary>
        /// <returns>Listado de Causas</returns>
        public List<AnalisisCausa> ObtenerAnalisisCausas()
        {
            try
            {
                return _modulOtecEntities.AnalisisCausa.ToList();
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
        /// Método que obtiene un Análisis por su Id
        /// </summary>
        /// <param name="idAnalisis">Id del Análisis</param>
        /// <returns>Análisis de la Causa</returns>
        public AnalisisCausa ObtenerAnalisisCausa(int idAnalisis)
        {
            try
            {
                return _modulOtecEntities.AnalisisCausa.Single(o => idAnalisis.Equals(o.IdAnalisisCausa));
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
        /// Método que actualiza un Análisis de la Causa
        /// </summary>
        /// <param name="analisisCausa">Datos del Análisis</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarAnalisisCausa(AnalisisCausa analisisCausa)
        {
            try
            {
                var original = _modulOtecEntities.AnalisisCausa.Find(analisisCausa.IdIncidencia);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(analisisCausa);
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
        /// Método que elimina un Análisis de la Causa
        /// </summary>
        /// <param name="idAnalisis">Id del Análisis</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarAnalisisCausa(int idAnalisis)
        {
            try
            {
                var entidad = _modulOtecEntities.AnalisisCausa.Find(idAnalisis);
                if (entidad == null) return 0;
                _modulOtecEntities.AnalisisCausa.Remove(entidad);
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
