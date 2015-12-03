namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para las Evaluaciones de Cumplimiento
    /// </summary>
    public class EvaluacionesCumplimientoDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public EvaluacionesCumplimientoDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea una Evaluación de Cumplimiento
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEvaluacionCumplimiento(EvaluacionCumplimiento evaluacion)
        {
            try
            {
                _modulOtecEntities.EvaluacionCumplimiento.Add(evaluacion);
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
        /// Método que obtiene todas las Evaluaciones de Cumplimiento
        /// </summary>
        /// <returns>Listado de Evaluaciones</returns>
        public List<EvaluacionCumplimiento> ObtenerEvaluacionesCumplimiento()
        {
            try
            {
                return _modulOtecEntities.EvaluacionCumplimiento.ToList();
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
        /// Método que obtiene una Evaluación de Cumplimiento por su Id
        /// </summary>
        /// <param name="idEvaluacion">Id de la Evaluacion</param>
        /// <returns>Evaluación de Cumplimiento</returns>
        public EvaluacionCumplimiento ObtenerEvaluacionCumplimiento(int idEvaluacion)
        {
            try
            {
                return _modulOtecEntities.EvaluacionCumplimiento.Single(o => idEvaluacion.Equals(o.IdEvaluacion));
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
        /// Método que actualiza una Evaluación de Cumplimiento
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEvaluacionCumplimiento(EvaluacionCumplimiento evaluacion)
        {
            try
            {
                var original = _modulOtecEntities.EvaluacionCumplimiento.Find(evaluacion.IdEvaluacion);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(evaluacion);
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
        /// Método que elimina una Evaluación de Cumplimiento
        /// </summary>
        /// <param name="idEvaluacion">Id de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEvaluacionCumplimiento(int idEvaluacion)
        {
            try
            {
                var entidad = _modulOtecEntities.EvaluacionCumplimiento.Find(idEvaluacion);
                if (entidad == null) return 0;
                _modulOtecEntities.EvaluacionCumplimiento.Remove(entidad);
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
