//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tarea
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> tiempo { get; set; }
        public Nullable<int> iduser { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}