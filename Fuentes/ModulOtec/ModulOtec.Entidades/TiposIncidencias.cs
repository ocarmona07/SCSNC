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
    
    public partial class TiposIncidencias
    {
        public TiposIncidencias()
        {
            this.Incidencias = new HashSet<Incidencias>();
        }
    
        public int IdTipoIncidencia { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    
        public virtual ICollection<Incidencias> Incidencias { get; set; }
    }
}
