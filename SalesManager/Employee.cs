namespace SalesManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [StringLength(150)]
        [Display(Name = "ФИО сотрудника")]
        public string Name { get; set; }

        [StringLength(150)]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Display(Name = "Должность")]
        public int? Position { get; set; }

        public virtual Position Position1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
