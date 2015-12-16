namespace ModulOtec.Negocio
{
    using System.Collections.Generic;
    using Datos;
    using Entidades;

    /// <summary>
    /// Clase de negocio para Evaluaciones de Cumplimiento
    /// </summary>
    public class EvaluacionesCumplimientoBo
    {
        private readonly EvaluacionesCumplimientoDa _evaluacionesDa;

        /// <summary>
        /// Método que instancia la clase EvaluacionesCumplimientoBo
        /// </summary>
        public EvaluacionesCumplimientoBo()
        {
            if (_evaluacionesDa == null)
            {
                _evaluacionesDa = new EvaluacionesCumplimientoDa();
            }
        }

        /// <summary>
        /// Método que crea una evaluación
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int CrearEvaluacionCumplimiento(EvaluacionCumplimiento evaluacion)
        {
            return _evaluacionesDa.CrearEvaluacionCumplimiento(evaluacion);
        }

        /// <summary>
        /// Método que obtiene todas las Evaluaciones de Cumplimiento
        /// </summary>
        /// <returns>Lista de Evaluaciones</returns>
        public List<EvaluacionCumplimiento> ObtenerEvaluacionesCumplimiento()
        {
            return _evaluacionesDa.ObtenerEvaluacionesCumplimiento();
        }

        /// <summary>
        /// Método que obtiene una evaluación por Id
        /// </summary>
        /// <param name="idEvaluacion">Id de la evaluación</param>
        /// <returns>Evaluación de Cumplimiento</returns>
        public EvaluacionCumplimiento ObtenerEvaluacionCumplimiento(int idEvaluacion)
        {
            return _evaluacionesDa.ObtenerEvaluacionCumplimiento(idEvaluacion);
        }

        /// <summary>
        /// Método que actualiza una Evaluación
        /// </summary>
        /// <param name="evaluacion">Datos de la Evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarEvaluacionCumplimiento(EvaluacionCumplimiento evaluacion)
        {
            return _evaluacionesDa.ActualizarEvaluacionCumplimiento(evaluacion);
        }

        /// <summary>
        /// Método que elimina una Evaluación
        /// </summary>
        /// <param name="idEvaluacion">Id de la evaluación</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarEvaluacionCumplimiento(int idEvaluacion)
        {
            return _evaluacionesDa.EliminarEvaluacionCumplimiento(idEvaluacion);
        }
    }
}
