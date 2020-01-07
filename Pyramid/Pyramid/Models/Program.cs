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
    
    public partial class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program()
        {
            this.ASQSE = new HashSet<ASQSE>();
            this.BenchmarkOfQuality = new HashSet<BenchmarkOfQuality>();
            this.BenchmarkOfQualityFCC = new HashSet<BenchmarkOfQualityFCC>();
            this.ChildNote = new HashSet<ChildNote>();
            this.ChildProgram = new HashSet<ChildProgram>();
            this.ChildStatus = new HashSet<ChildStatus>();
            this.Classroom = new HashSet<Classroom>();
            this.LoginHistory = new HashSet<LoginHistory>();
            this.ProgramType = new HashSet<ProgramType>();
            this.OtherSEScreen = new HashSet<OtherSEScreen>();
            this.UserProgramRole = new HashSet<UserProgramRole>();
            this.CoachingLog = new HashSet<CoachingLog>();
            this.NewsEntry = new HashSet<NewsEntry>();
            this.UserFileUpload = new HashSet<UserFileUpload>();
            this.ProgramEmployee = new HashSet<ProgramEmployee>();
        }
    
        public int ProgramPK { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public string Location { get; set; }
        public string ProgramName { get; set; }
        public int CohortFK { get; set; }
        public int HubFK { get; set; }
        public int StateFK { get; set; }
        public Nullable<System.DateTime> ProgramEndDate { get; set; }
        public System.DateTime ProgramStartDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASQSE> ASQSE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenchmarkOfQuality> BenchmarkOfQuality { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BenchmarkOfQualityFCC> BenchmarkOfQualityFCC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildNote> ChildNote { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildProgram> ChildProgram { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildStatus> ChildStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classroom> Classroom { get; set; }
        public virtual Cohort Cohort { get; set; }
        public virtual Hub Hub { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginHistory> LoginHistory { get; set; }
        public virtual State State { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramType> ProgramType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OtherSEScreen> OtherSEScreen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProgramRole> UserProgramRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoachingLog> CoachingLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsEntry> NewsEntry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFileUpload> UserFileUpload { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgramEmployee> ProgramEmployee { get; set; }
    }
}
