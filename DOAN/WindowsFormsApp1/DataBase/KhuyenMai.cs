namespace WindowsFormsApp1.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        public int MKM { get; set; }

        public DateTime? NgayBD { get; set; }

        public DateTime? NgayKT { get; set; }

        [Key]
        public int MaKM { get; set; }
    }
}
