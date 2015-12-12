namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para la Organización
    /// </summary>
    public class OrganizacionesDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public OrganizacionesDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea una Organización
        /// </summary>
        /// <param name="organizacion">Datos de la Organización</param>
        /// <returns>Id de confirmación</returns>
        public int CrearOrganizacion(Organizacion organizacion)
        {
            try
            {
                _modulOtecEntities.Organizacion.Add(organizacion);
                _modulOtecEntities.SaveChanges();
                return organizacion.IdOrganizacion;
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
        /// Método que obtiene todas las Organizaciones
        /// </summary>
        /// <returns>Listado de Organizaciones</returns>
        public List<Organizacion> ObtenerOrganizaciones()
        {
            try
            {
                return _modulOtecEntities.Organizacion.ToList();
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
        /// Método que obtiene una Organización por su Id
        /// </summary>
        /// <param name="idOrganizacion">Id de la Organización</param>
        /// <returns>Organización</returns>
        public Organizacion ObtenerOrganizacion(int idOrganizacion)
        {
            try
            {
                return _modulOtecEntities.Organizacion.Single(o => idOrganizacion.Equals(o.IdOrganizacion));
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
        /// Método que actualiza una Organización
        /// </summary>
        /// <param name="organizacion">Datos de la Organización</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarOrganizacion(Organizacion organizacion)
        {
            try
            {
                var original = _modulOtecEntities.Organizacion.Find(organizacion.IdOrganizacion);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(organizacion);
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
        /// Método que elimina una Organización
        /// </summary>
        /// <param name="idOrganizacion">Id de la Organización</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarOrganizacion(int idOrganizacion)
        {
            try
            {
                var entidad = _modulOtecEntities.Organizacion.Find(idOrganizacion);
                if (entidad == null) return 0;
                _modulOtecEntities.Organizacion.Remove(entidad);
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
