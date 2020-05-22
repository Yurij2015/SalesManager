namespace SalesManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "�������� ��������")]
        public string CompanyName { get; set; }

        [StringLength(50)]
        [Display(Name = "����� ��������")]
        public string Phone { get; set; }

        [StringLength(150)]
        [Display(Name = "��� ���������")]
        public string DirectorName { get; set; }

        [StringLength(50)]
        [Display(Name = "�����")]
        public string Adress { get; set; }

        [StringLength(50)]
        [Display(Name = "����������� �����")]
        public string Email { get; set; }

        [StringLength(150)]
        [Display(Name = "�������������� ����������")]
        public string AccessInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
