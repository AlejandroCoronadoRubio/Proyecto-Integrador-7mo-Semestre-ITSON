//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class orden
    {
        public int idOrden { get; set; }
        public Nullable<System.DateTime> horaInicio { get; set; }
        public Nullable<System.DateTime> horaFin { get; set; }
        public string notas { get; set; }
        public int idCliente { get; set; }
        public int idUsuarios { get; set; }
        public int idComponente { get; set; }
    
        public virtual almacen almacen { get; set; }
        public virtual clientes clientes { get; set; }
        public virtual usuarios usuarios { get; set; }
    }
}