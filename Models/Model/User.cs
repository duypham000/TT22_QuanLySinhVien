namespace QuanLySinhVien.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [StringLength(250)]
        public string Username { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string InforID { get; set; }

        public int RoleID { get; set; }

        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public int? Age { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool Status { get; set; }

        public virtual Role Role { get; set; }

        public virtual Student Student { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
