namespace WindowsFormsApp1.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("account")]
    public partial class account
    {
        [Key]
        [StringLength(20)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        public int? ChucVu { get; set; }

        public int? Type { get; set; }
    }
}
