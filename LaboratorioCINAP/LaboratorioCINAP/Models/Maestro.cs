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
    
    public partial class Maestro
    {
        public Maestro()
        {
            this.RegistroPrestamoLaboratorio = new HashSet<RegistroPrestamoLaboratorio>();
        }
    
        public int ID_Maestro { get; set; }
        public int ID_Persona { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    
        public virtual ICollection<RegistroPrestamoLaboratorio> RegistroPrestamoLaboratorio { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
