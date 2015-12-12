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
    
    public partial class Incidencias
    {
        public Incidencias()
        {
            this.AnalisisCausa = new HashSet<AnalisisCausa>();
        }
    
        public int IdIncidencia { get; set; }
        public int RutCreador { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public int IdTipoIncidencia { get; set; }
        public int IdModoDeteccion { get; set; }
        public System.DateTime FechaIdentificacion { get; set; }
        public string AreaAfectada { get; set; }
        public string ProcesoAfectado { get; set; }
        public string Descripcion { get; set; }
        public int IdEstadoIncidencia { get; set; }
    
        public virtual ICollection<AnalisisCausa> AnalisisCausa { get; set; }
        public virtual EstadosIncidencia EstadosIncidencia { get; set; }
        public virtual ModosDeteccion ModosDeteccion { get; set; }
        public virtual TiposIncidencias TiposIncidencias { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
