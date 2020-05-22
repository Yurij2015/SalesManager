namespace SalesManager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contract
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "�������� ��������")]
        public string ContractName { get; set; }

        [Display(Name = "�����")]
        public int? Order { get; set; }

        [StringLength(150)]
        [Display(Name = "�������������� ����������")]
        public string AcessInfo { get; set; }

        public virtual Order Order1 { get; set; }
    }
}
