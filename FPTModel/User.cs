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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Couse_Cat = new HashSet<Couse_Cat>();
        }
    
        public string UserID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
        public Nullable<int> ID_Role { get; set; }
        public Nullable<bool> is_admin { get; set; }
        public Nullable<bool> is_TrainingStaff { get; set; }
        public Nullable<bool> is_Trainer { get; set; }
        public Nullable<bool> is_Trainee { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Couse_Cat> Couse_Cat { get; set; }
        public virtual Role Role { get; set; }
    }
}