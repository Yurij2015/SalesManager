namespace SalesManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Contracts = new HashSet<Contract>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "�������� ������")]
        public string OrderName { get; set; }

        [Display(Name = "��������")]
        public int? Customer { get; set; }

        [Display(Name = "������")]
        public int? Service { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "���� ������")]
        public DateTime? OrderDate { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "���� ���������� ������")]
        public DateTime? FinishDate { get; set; }

        [Display(Name = "�����������")]
        public int? Emplotyee { get; set; }

        [Display(Name = "������ ������")]
        public int? Status { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "��������� ������")]
        public decimal? Cost { get; set; }

        [Display(Name = "������ ������")]
        public int? CostStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }

        public virtual Customer Customer1 { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        public virtual PayStatu PayStatu { get; set; }

        public virtual Service Service1 { get; set; }
    }
}
