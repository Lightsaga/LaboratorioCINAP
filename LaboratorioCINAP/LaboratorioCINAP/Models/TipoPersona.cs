//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaboratorioCINAP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoPersona
    {
        public TipoPersona()
        {
            this.Persona = new HashSet<Persona>();
        }
    
        public int ID_TipoPersona { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
