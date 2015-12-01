namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para los Usuarios
    /// </summary>
    public class UsuariosDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public UsuariosDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int CrearUsuario(Usuarios usuario)
        {
            try
            {
                _modulOtecEntities.Usuarios.Add(usuario);
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
        /// Método que obtiene todos los Usuarios
        /// </summary>
        /// <returns>Lista de Usuarios</returns>
        public List<Usuarios> ObtenerUsuarios()
        {
            try
            {
                return _modulOtecEntities.Usuarios.ToList();
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
        /// Método que obtiene un usuario por su RUT
        /// </summary>
        /// <param name="rutUsuario">RUT del Usuario</param>
        /// <returns>Usuario</returns>
        public Usuarios ObtenerUsuario(int rutUsuario)
        {
            try
            {
                return _modulOtecEntities.Usuarios.Single(o => rutUsuario.Equals(o.RUT));
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
        /// Método que actualiza un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarUsuario(Usuarios usuario)
        {
            try
            {
                var original = _modulOtecEntities.Usuarios.Find(usuario.RUT);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(usuario);
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
        /// Método que elimina un Usuario
        /// </summary>
        /// <param name="rutUsuario">RUT del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUsuario(int rutUsuario)
        {
            try
            {
                var entidad = _modulOtecEntities.Usuarios.Find(rutUsuario);
                if (entidad == null) return 0;
                _modulOtecEntities.Usuarios.Remove(entidad);
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
