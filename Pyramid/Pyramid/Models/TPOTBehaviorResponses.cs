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
    
    public partial class TPOTBehaviorResponses
    {
        public int TPOTBehaviorResponsesPK { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int TPOTFK { get; set; }
        public int BehaviorResponseCodeFK { get; set; }
    
        public virtual CodeTPOTBehaviorResponse CodeTPOTBehaviorResponse { get; set; }
        public virtual TPOT TPOT { get; set; }
    }
}
