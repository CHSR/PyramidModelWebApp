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
    
    public partial class TPITOSParticipant
    {
        public int TPITOSParticipantPK { get; set; }
        public int ParticipantTypeCodeFK { get; set; }
        public int ProgramEmployeeFK { get; set; }
        public int TPITOSFK { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
    
        public virtual CodeParticipantType CodeParticipantType { get; set; }
        public virtual TPITOS TPITOS { get; set; }
        public virtual ProgramEmployee ProgramEmployee { get; set; }
    }
}