namespace ModulOtec.Negocio
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Datos;
    using Entidades;

    /// <summary>
    /// Clase de negocio para Documentos
    /// </summary>
    public class DocumentosBo
    {
        private readonly DocumentosDa _documentosDa;

        /// <summary>
        /// Método que instancia la clase DocumentosBo
        /// </summary>
        public DocumentosBo()
        {
            if (_documentosDa == null)
            {
                _documentosDa = new DocumentosDa();
            }
        }

        /// <summary>
        /// Método que crea un Documento
        /// </summary>
        /// <param name="documento">Datos del Documento</param>
        /// <returns>Id de confirmación</returns>
        public int CrearDocumento(Documentos documento)
        {
            return _documentosDa.CrearDocumento(documento);
        }

        /// <summary>
        /// Método que obtiene todos los Documentos
        /// </summary>
        /// <returns>Lista de Documentos</returns>
        public List<Documentos> ObtenerDocumentos()
        {
            return _documentosDa.ObtenerDocumentos();
        }

        /// <summary>
        /// Método que obtiene todos los Documentos por el Id de la incidencia
        /// </summary>
        /// <param name="idIncidencia">Id de la incidencia</param>
        /// <returns>Lista de Documentos</returns>
        public List<Documentos> ObtenerDocumentosPorIncidencia(int idIncidencia)
        {
            try
            {
                return _documentosDa.ObtenerDocumentos().Where(o => idIncidencia.Equals(o.IdIncidencia)).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que obtiene un documento por su Id
        /// </summary>
        /// <param name="idDocumento">Id del Documento</param>
        /// <returns>Documento</returns>
        public Documentos ObtenerDocumento(int idDocumento)
        {
            return _documentosDa.ObtenerDocumento(idDocumento);
        }

        /// <summary>
        /// Método que actualiza un Documento
        /// </summary>
        /// <param name="documento">Datos del Documento</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarDocumento(Documentos documento)
        {
            return _documentosDa.ActualizarDocumento(documento);
        }

        /// <summary>
        /// Método que elimina un Documento
        /// </summary>
        /// <param name="idDocumento">Id del Documento</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarDocumento(int idDocumento)
        {
            return _documentosDa.EliminarDocumento(idDocumento);
        }
    }
}
