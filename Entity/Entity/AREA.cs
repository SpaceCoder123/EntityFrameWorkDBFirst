//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AREA
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public Nullable<int> CityID { get; set; }
    
        public virtual CITy CITy { get; set; }
    }
}