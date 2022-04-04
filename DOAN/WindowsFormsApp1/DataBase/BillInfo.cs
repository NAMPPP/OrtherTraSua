namespace WindowsFormsApp1.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        [Key]
        public int MACTHD { get; set; }

        public int? MAHD { get; set; }

        public int? MAMON { get; set; }

        public int? SOLUONG { get; set; }

        public virtual BILL BILL { get; set; }

        public virtual Drink Drink { get; set; }
    }
}
