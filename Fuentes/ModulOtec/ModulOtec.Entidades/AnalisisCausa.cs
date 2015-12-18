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
            this.Acciones = new HashSet<Acciones>();
            this.EvaluacionCumplimiento = new HashSet<EvaluacionCumplimiento>();
        }
    
        public int IdAnalisisCausa { get; set; }
        public int IdIncidencia { get; set; }
        public string CausasPotenciales { get; set; }
        public string EfectosDeseados { get; set; }
        public int IdTratamiento { get; set; }
    
        public virtual ICollection<Acciones> Acciones { get; set; }
        public virtual Tratamientos Tratamientos { get; set; }
        public virtual ICollection<EvaluacionCumplimiento> EvaluacionCumplimiento { get; set; }
        public virtual Incidencias Incidencias { get; set; }
    }
}
