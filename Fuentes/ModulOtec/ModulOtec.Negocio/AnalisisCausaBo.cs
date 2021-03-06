﻿namespace ModulOtec.Negocio
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Datos;
    using Entidades;

    /// <summary>
    /// Clase de negocio para Análisis de la Causa
    /// </summary>
    public class AnalisisCausasBo
    {
        private readonly AnalisisCausasDa _analisisCausasDa;

        /// <summary>
        /// Método que instancia la clase AnalisisCausasDa
        /// </summary>
        public AnalisisCausasBo()
        {
            if (_analisisCausasDa == null)
            {
                _analisisCausasDa = new AnalisisCausasDa();
            }
        }

        /// <summary>
        /// Método que crea un Análisis
        /// </summary>
        /// <param name="analisis">Datos del Análisis</param>
        /// <returns>Id de confirmación</returns>
        public int CrearAnalisisCausa(AnalisisCausa analisis)
        {
            return _analisisCausasDa.CrearAnalisisCausa(analisis);
        }

        /// <summary>
        /// Método que obtiene todos los Análisis
        /// </summary>
        /// <returns>Lista de Análisis</returns>
        public List<AnalisisCausa> ObtenerAnalisisCausas()
        {
            return _analisisCausasDa.ObtenerAnalisisCausas();
        }

        /// <summary>
        /// Método que obtiene un análisis por su Id
        /// </summary>
        /// <param name="idAnalisis">Id del Análisis</param>
        /// <returns>Análisis</returns>
        public AnalisisCausa ObtenerAnalisisCausa(int idAnalisis)
        {
            return _analisisCausasDa.ObtenerAnalisisCausa(idAnalisis);
        }

        /// <summary>
        /// Método que obtiene un análisis por el Id de la Incidencia
        /// </summary>
        /// <param name="idIncidencia">Id de la Incidencia</param>
        /// <returns>Análisis</returns>
        public AnalisisCausa ObtenerAnalisisExistente(int idIncidencia)
        {
            try
            {
                return _analisisCausasDa.ObtenerAnalisisCausas().First(o => idIncidencia.Equals(o.IdIncidencia));
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Método que actualiza un Análisis
        /// </summary>
        /// <param name="analisis">Datos del Análisis</param>
        /// <returns>Id de confirmación</returns>
        public int ActualizarAnalisisCausa(AnalisisCausa analisis)
        {
            return _analisisCausasDa.ActualizarAnalisisCausa(analisis);
        }

        /// <summary>
        /// Método que elimina un Análisis
        /// </summary>
        /// <param name="idAnalisis">Id del Análisis</param>
        /// <returns>Id de confirmación</returns>
        public int EliminarAnalisisCausa(int idAnalisis)
        {
            return _analisisCausasDa.EliminarAnalisisCausa(idAnalisis);
        }
    }
}
