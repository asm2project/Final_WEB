//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FPTModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Couse_Cat
    {
        public long CC_ID { get; set; }
        public string UserID { get; set; }
        public string Couse_ID { get; set; }
        public Nullable<int> Role_id { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
