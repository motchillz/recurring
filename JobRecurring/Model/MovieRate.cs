//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobRecurring.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovieRate
    {
        public int Id { get; set; }
        public int Point { get; set; }
        public int ProductId { get; set; }
        public string Ip { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}