//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcoWise.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobSegment
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public System.DateTime SegmentDate { get; set; }
        public int MachineId { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public int StartClicks { get; set; }
        public Nullable<int> EndClicks { get; set; }
        public int EmployeeCrewId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual Job Job { get; set; }
    }
}
