//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace William01.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserList
    {
        public int Id { get; set; }
        public string NombreUsario { get; set; }
        public string Apellido { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Pass { get; set; }
        public Nullable<int> IdTypeOfUser { get; set; }
    
        public virtual TypeOfUser TypeOfUser { get; set; }
    }
}
