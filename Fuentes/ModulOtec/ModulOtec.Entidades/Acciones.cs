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
    
    public partial class Acciones
    {
        public int IdAccion { get; set; }
        public int IdAnalisisCausa { get; set; }
        public string DescAccion { get; set; }
        public Nullable<int> IdEstado { get; set; }
    
        public virtual EstadosAccion EstadosAccion { get; set; }
        public virtual AnalisisCausa AnalisisCausa { get; set; }
    }
}
