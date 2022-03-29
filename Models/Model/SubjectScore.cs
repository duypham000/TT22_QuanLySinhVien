namespace QuanLySinhVien.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubjectScore
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentID { get; set; }

        [StringLength(50)]
        public string SubjectID { get; set; }

        public double? Attendance { get; set; }

        public double? Midterm { get; set; }

        public double? Practice { get; set; }

        public double? Final { get; set; }

        public double? Discussion { get; set; }

        public double? Assessment { get; set; }

        [StringLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(250)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
