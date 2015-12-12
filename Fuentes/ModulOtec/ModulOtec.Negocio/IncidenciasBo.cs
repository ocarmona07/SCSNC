namespace ModulOtec.Negocio
{
    using System.Collections.Generic;
    using Datos;
    using Entidades;

    /// <summary>
    /// Clase de negocio para Incidencias
    /// </summary>
    public class IncidenciasBo
    {
        private readonly IncidenciasDa _incidenciasDa;

        /// <summary>
        /// Método que instancia la clase IncidenciasDa
        /// </summary>
        public IncidenciasBo()
        {
            if (_incidenciasDa == null)
            {
                _incidenciasDa = new IncidenciasDa();
            }
        }

        /// <summary>
        /// Método que crea una Incidencia
        /// </summary>
        /// <param name="incidencia">Datos de la Incidencia</param>
        /// <returns>Id de confirmación</returns>
        public int CrearIncidencia(Incidencias incidencia)
        {
            return _incidenciasDa.CrearIncidencia(incidencia);
        }

        /// <summary>
        /// Método que obtiene todas las Incidencias
        /// </summary>
        /// <returns>Lista de Incidencias</returns>
        public List<Incidencias> ObtenerIncidencias()
        {
            return _incidenciasDa.ObtenerIncidencias();
        }

        /// <summary>
        /// Método que obtiene una incidencia por su ID
        /// </summary>
        /// <param name="idIncidencia">ID de la Incidencia</param>
        /// <returns>Incidencia</returns>
        public Incidencias ObtenerIncidencia(int idIncidencia)
        {
            return _incidenciasDa.ObtenerIncidencia(idIncidencia);
        }

        /// <summary>
        /// Método que actualiza una Incidencia
        /// </summary>
        /// <param name="incidencia">Datos de la Incidencia</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarIncidencia(Incidencias incidencia)
        {
            return _incidenciasDa.ActualizarIncidencia(incidencia);
        }

        /// <summary>
        /// Método que elimina una Incidencia
        /// </summary>
        /// <param name="idIncidencia">ID de la Incidencia</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarIncidencia(int idIncidencia)
        {
            return _incidenciasDa.EliminarIncidencia(idIncidencia);
        }
    }
}
