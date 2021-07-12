namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Couse_Cat = new HashSet<Couse_Cat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(200)]
        public string Fullname { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Username { get; set; }

        [StringLength(200)]
        public string password { get; set; }

        public int? ID_Role { get; set; }

        public bool? is_admin { get; set; }

        public bool? is_TrainingStaff { get; set; }

        public bool? is_Trainer { get; set; }

        public bool? is_Trainee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Couse_Cat> Couse_Cat { get; set; }

        public virtual Role Role { get; set; }
    }
}
