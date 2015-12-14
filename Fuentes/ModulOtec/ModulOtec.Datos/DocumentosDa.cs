namespace ModulOtec.Datos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;

    /// <summary>
    /// Clase de datos para los Documentos
    /// </summary>
    public class DocumentosDa
    {
        /// <summary>
        /// Entidades de ModulOTEC
        /// </summary>
        private readonly ModulOTECEntities _modulOtecEntities;

        /// <summary>
        /// Método que obtiene las entidades de ModulOTEC
        /// </summary>
        public DocumentosDa()
        {
            if (_modulOtecEntities == null)
            {
                _modulOtecEntities = new ModulOTECEntities();
            }
        }

        /// <summary>
        /// Método que crea un Documento
        /// </summary>
        /// <param name="documento">Datos del Documento</param>
        /// <returns>Id de confirmación</returns>
        public int CrearDocumento(Documentos documento)
        {
            try
            {
                _modulOtecEntities.Documentos.Add(documento);
                _modulOtecEntities.SaveChanges();
                return documento.IdDocumento;
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
        /// Método que obtiene todos los Documentos
        /// </summary>
        /// <returns>Lista de Documentos</returns>
        public List<Documentos> ObtenerDocumentos()
        {
            try
            {
                return _modulOtecEntities.Documentos.ToList();
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
        /// Método que obtiene un documento por su Id
        /// </summary>
        /// <param name="idDocumento">Id del Documento</param>
        /// <returns>Documento</returns>
        public Documentos ObtenerDocumento(int idDocumento)
        {
            try
            {
                return _modulOtecEntities.Documentos.Single(o => idDocumento.Equals(o.IdDocumento));
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
        /// Método que actualiza un Documento
        /// </summary>
        /// <param name="documento">Datos del Documento</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarDocumento(Documentos documento)
        {
            try
            {
                var original = _modulOtecEntities.Documentos.Find(documento.IdDocumento);
                if (original == null) return 0;
                _modulOtecEntities.Entry(original).CurrentValues.SetValues(documento);
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
        /// Método que elimina un Documento
        /// </summary>
        /// <param name="idDocumento">Id del Documento</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarDocumento(int idDocumento)
        {
            try
            {
                var entidad = _modulOtecEntities.Documentos.Find(idDocumento);
                if (entidad == null) return 0;
                _modulOtecEntities.Documentos.Remove(entidad);
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
