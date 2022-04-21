namespace QuanLySinhVien.Models.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Classes = new HashSet<Class>();
        }

        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string DateOfBirth { get; set; }

        public string SchoolProfile { get; set; }

        [StringLength(250)]
        public string Religion { get; set; }

        [StringLength(250)]
        public string ClassRole { get; set; }

        [StringLength(50)]
        public string ClassID { get; set; }

        [StringLength(250)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(250)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Class> Classes { get; set; }

        public virtual Class Class { get; set; }
    }
}
