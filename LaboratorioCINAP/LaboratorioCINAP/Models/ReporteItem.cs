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
    
    public partial class ReporteItem
    {
        public int ID_ReporteItem { get; set; }
        public int ID_Reporte { get; set; }
        public int ID_Grupo { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Grupo Grupo { get; set; }
        public virtual Reporte Reporte { get; set; }
    }
}
