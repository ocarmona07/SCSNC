namespace ModulOtec.Negocio
{
    using System.Collections.Generic;
    using Datos;
    using Entidades;

    /// <summary>
    /// Clase de negocio para Usuarios
    /// </summary>
    public class UsuariosBo
    {
        private readonly UsuariosDa _usuariosDa;

        /// <summary>
        /// Método que instancia la clase UsuariosDa
        /// </summary>
        public UsuariosBo()
        {
            if (_usuariosDa == null)
            {
                _usuariosDa = new UsuariosDa();
            }
        }

        /// <summary>
        /// Método que crea un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int CrearUsuario(Usuarios usuario)
        {
            return _usuariosDa.CrearUsuario(usuario);
        }

        /// <summary>
        /// Método que obtiene todos los Usuarios
        /// </summary>
        /// <returns>Lista de Usuarios</returns>
        public List<Usuarios> ObtenerUsuarios()
        {
            return _usuariosDa.ObtenerUsuarios();
        }

        /// <summary>
        /// Método que obtiene un usuario por su RUT
        /// </summary>
        /// <param name="rutUsuario">RUT del Usuario</param>
        /// <returns>Usuario</returns>
        public Usuarios ObtenerUsuario(int rutUsuario)
        {
            return _usuariosDa.ObtenerUsuario(rutUsuario);
        }

        /// <summary>
        /// Método que actualiza un Usuario
        /// </summary>
        /// <param name="usuario">Datos del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarUsuario(Usuarios usuario)
        {
            return _usuariosDa.ActualizarUsuario(usuario);
        }

        /// <summary>
        /// Método que elimina un Usuario
        /// </summary>
        /// <param name="rutUsuario">RUT del Usuario</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarUsuario(int rutUsuario)
        {
            return _usuariosDa.EliminarUsuario(rutUsuario);
        }
    }
}
