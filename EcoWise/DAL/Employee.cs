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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Employee_EmployeeCrews = new HashSet<Employee_EmployeeCrews>();
            this.Employee_EmployeeTypes = new HashSet<Employee_EmployeeTypes>();
            this.EmployeeWorkTimes = new HashSet<EmployeeWorkTime>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<decimal> DefaultPay { get; set; }
        public string CellNumber { get; set; }
        public Nullable<int> AddressId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_EmployeeCrews> Employee_EmployeeCrews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_EmployeeTypes> Employee_EmployeeTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeWorkTime> EmployeeWorkTimes { get; set; }
    }
}
