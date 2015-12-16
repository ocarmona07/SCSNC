namespace ModulOtec.Negocio
{
    using System.Collections.Generic;
    using System.Linq;
    using Datos;
    using Entidades;

    /// <summary>
    /// Clase de negocio para las Acciones
    /// </summary>
    public class AccionesBo
    {
        private readonly AccionesDa _accionesDa;

        /// <summary>
        /// Método que instancia la clase AccionesDa
        /// </summary>
        public AccionesBo()
        {
            if (_accionesDa == null)
            {
                _accionesDa = new AccionesDa();
            }
        }

        /// <summary>
        /// Método que crea una Acción
        /// </summary>
        /// <param name="accion">Datos de la Acción</param>
        /// <returns>Id de confirmación</returns>
        public int CrearAccion(Acciones accion)
        {
            return _accionesDa.CrearAccion(accion);
        }

        /// <summary>
        /// Método que obtiene tados las Acciones
        /// </summary>
        /// <returns>Lista de Acciones</returns>
        public List<Acciones> ObtenerAcciones()
        {
            return _accionesDa.ObtenerAcciones();
        }

        /// <summary>
        /// Método que obtiene una acción por su Id
        /// </summary>
        /// <param name="idAccion">Id de la acción</param>
        /// <returns>Acción</returns>
        public Acciones ObtenerAccion(int idAccion)
        {
            return _accionesDa.ObtenerAccion(idAccion);
        }

        /// <summary>
        /// Método que obtiene una lista de acciones por el Id del análisis
        /// </summary>
        /// <param name="idAnalisis">Id del análisis</param>
        /// <returns>Lista de Acciones</returns>
        public List<Acciones> ObtenerAccionesPorAnalisis(int idAnalisis)
        {
            return _accionesDa.ObtenerAcciones().Where(o => idAnalisis.Equals(o.IdAnalisisCausa)).ToList();
        }

        /// <summary>
        /// Método que actualiza una Acción
        /// </summary>
        /// <param name="accion">Datos de la Acción</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarAccion(Acciones accion)
        {
            return _accionesDa.ActualizarAccion(accion);
        }

        /// <summary>
        /// Método que elimina una Accion
        /// </summary>
        /// <param name="idAccion">Id de la Acción</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarAnalisisCausa(int idAccion)
        {
            return _accionesDa.EliminarAccion(idAccion);
        }
    }
}
