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
    
    public partial class Grupo
    {
        public Grupo()
        {
            this.DetalleGrupo = new HashSet<DetalleGrupo>();
            this.RegistroPrestamoLaboratorio = new HashSet<RegistroPrestamoLaboratorio>();
            this.RegistroPrestamoMaterial = new HashSet<RegistroPrestamoMaterial>();
            this.ReporteItem = new HashSet<ReporteItem>();
        }
    
        public int ID_Grupo { get; set; }
        public Nullable<int> Semestre { get; set; }
        public string Materia { get; set; }
        public int ID_Carrera { get; set; }
    
        public virtual Carrera Carrera { get; set; }
        public virtual ICollection<DetalleGrupo> DetalleGrupo { get; set; }
        public virtual ICollection<RegistroPrestamoLaboratorio> RegistroPrestamoLaboratorio { get; set; }
        public virtual ICollection<RegistroPrestamoMaterial> RegistroPrestamoMaterial { get; set; }
        public virtual ICollection<ReporteItem> ReporteItem { get; set; }
    }
}
