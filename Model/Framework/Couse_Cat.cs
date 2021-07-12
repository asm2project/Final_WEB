namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Couse_Cat
    {
        [Key]
        public long CC_ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(50)]
        public string Couse_ID { get; set; }

        public virtual Cours Cours { get; set; }

        public virtual User User { get; set; }
    }
}
