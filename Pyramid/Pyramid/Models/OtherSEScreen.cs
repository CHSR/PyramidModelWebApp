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
    
    public partial class OtherSEScreen
    {
        public int OtherSEScreenPK { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public System.DateTime ScreenDate { get; set; }
        public int Score { get; set; }
        public int ChildFK { get; set; }
        public int ProgramFK { get; set; }
        public int ScoreTypeCodeFK { get; set; }
        public int ScreenTypeCodeFK { get; set; }
    
        public virtual Child Child { get; set; }
        public virtual CodeScoreType CodeScoreType { get; set; }
        public virtual CodeScreenType CodeScreenType { get; set; }
        public virtual Program Program { get; set; }
    }
}
