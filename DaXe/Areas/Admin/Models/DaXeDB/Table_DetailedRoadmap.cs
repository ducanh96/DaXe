//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DaXe.Areas.Admin.Models.DaXeDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_DetailedRoadmap
    {
        public int ID { get; set; }
        public string LocationDetails { get; set; }
        public Nullable<int> IDRoute { get; set; }
    
        public virtual Table_Route Table_Route { get; set; }
    }
}
