namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para la Acciones
    /// </summary>
    public class AccionesDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public AccionesDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea una Acción
        /// </summary>
        /// <param name="accion">Datos de la Acción</param>
        /// <returns>Id de confirmación</returns>
        public int CrearAccion(Acciones accion)
        {
            try
            {
                _modulOtecEntities.Acciones.Add(accion);
                _modulOtecEntities.SaveChanges();
                return accion.IdAccion;
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
        /// Método que obtiene todas las Acciones
        /// </summary>
        /// <returns>Listado de Acciones</returns>
        public List<Acciones> ObtenerAcciones()
        {
            try
            {
                return _modulOtecEntities.Acciones.ToList();
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
        /// Método que obtiene una Acción por su Id
        /// </summary>
        /// <param name="idAccion">Id de la Acción</param>
        /// <returns>Acción</returns>
        public Acciones ObtenerAccion(int idAccion)
        {
            try
            {
                return _modulOtecEntities.Acciones.Single(o => idAccion.Equals(o.IdAccion));
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
        /// Método que actualiza una Acción
        /// </summary>
        /// <param name="accion">Datos de la Acción</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarAccion(Acciones accion)
        {
            try
            {
                var original = _modulOtecEntities.Acciones.Find(accion.IdAccion);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(accion);
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
        /// Método que elimina una Acción
        /// </summary>
        /// <param name="idAccion">Id de la Acción</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarAccion(int idAccion)
        {
            try
            {
                var entidad = _modulOtecEntities.Acciones.Find(idAccion);
                if (entidad == null) return 0;
                _modulOtecEntities.Acciones.Remove(entidad);
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
