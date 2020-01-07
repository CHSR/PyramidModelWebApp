//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pyramid.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProgramEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgramEmployee()
        {
            this.CoachingLogCoach = new HashSet<CoachingLog>();
            this.CoachingLogTeacher = new HashSet<CoachingLog>();
            this.EmployeeClassroom = new HashSet<EmployeeClassroom>();
            this.JobFunction = new HashSet<JobFunction>();
            this.TPITOS = new HashSet<TPITOS>();
            this.TPITOSParticipant = new HashSet<TPITOSParticipant>();
            this.TPOT = new HashSet<TPOT>();
            this.TPOTParticipant = new HashSet<TPOTParticipant>();
            this.Training = new HashSet<Training>();
        }
    
        public int ProgramEmployeePK { get; set; }
        public string AspireID { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public System.DateTime HireDate { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> TermDate { get; set; }
        public string TermReasonSpecify { get; set; }
        public int ProgramFK { get; set; }
        public Nullable<int> TermReasonCodeFK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoachingLog> CoachingLogCoach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoachingLog> CoachingLogTeacher { get; set; }
        public virtual CodeTermReason CodeTermReason { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeClassroom> EmployeeClassroom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobFunction> JobFunction { get; set; }
        public virtual Program Program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPITOS> TPITOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPITOSParticipant> TPITOSParticipant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPOT> TPOT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TPOTParticipant> TPOTParticipant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Training> Training { get; set; }
    }
}
