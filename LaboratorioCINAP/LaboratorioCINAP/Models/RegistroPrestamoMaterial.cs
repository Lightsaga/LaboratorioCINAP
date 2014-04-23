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
    
    public partial class RegistroPrestamoMaterial
    {
        public int ID_RegistroPrestamoMaterial { get; set; }
        public int ID_Material { get; set; }
        public int ID_Persona { get; set; }
        public int ID_Grupo { get; set; }
        public bool Estado { get; set; }
        public string EstadoDescripcionEntrega { get; set; }
        public string EstadoDescripcionRecibido { get; set; }
        public bool EstadoFuncionalEntrega { get; set; }
        public Nullable<bool> EstadoFuncionalRecibido { get; set; }
        public System.DateTime FechaPrestamo { get; set; }
        public Nullable<System.DateTime> FechaRegreso { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        public virtual Material Material { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
