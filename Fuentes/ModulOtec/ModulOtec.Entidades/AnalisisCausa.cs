//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModulOtec.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnalisisCausa
    {
        public AnalisisCausa()
        {
            this.Documentos = new HashSet<Documentos>();
            this.EvaluacionCumplimiento = new HashSet<EvaluacionCumplimiento>();
        }
    
        public int IdAnalisisCausa { get; set; }
        public Nullable<int> IdIncidencia { get; set; }
        public string EfectosDeseados { get; set; }
        public string CausasPotenciales { get; set; }
        public Nullable<int> IdTratamiento { get; set; }
        public Nullable<int> idAccion { get; set; }
        public System.DateTime FechaLimite { get; set; }
    
        public virtual Acciones Acciones { get; set; }
        public virtual Incidencias Incidencias { get; set; }
        public virtual Tratamientos Tratamientos { get; set; }
        public virtual ICollection<Documentos> Documentos { get; set; }
        public virtual ICollection<EvaluacionCumplimiento> EvaluacionCumplimiento { get; set; }
    }
}
