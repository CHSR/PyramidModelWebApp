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
    
    public partial class ChildClassroom
    {
        public int ChildClassroomPK { get; set; }
        public System.DateTime AssignDate { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
        public string LeaveReasonSpecify { get; set; }
        public int ChildFK { get; set; }
        public int ClassroomFK { get; set; }
        public Nullable<int> LeaveReasonCodeFK { get; set; }
    
        public virtual Child Child { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual CodeChildLeaveReason CodeChildLeaveReason { get; set; }
    }
}
