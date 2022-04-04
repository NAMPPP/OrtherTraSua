namespace WindowsFormsApp1.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrderTraSua : DbContext
    {
        public OrderTraSua()
            : base("name=OrderTraSua")
        {
        }

        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<IMAGE> IMAGEs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<TableDrink> TableDrinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account>()
                .Property(e => e.TaiKhoan)
                .IsFixedLength();

            modelBuilder.Entity<account>()
                .Property(e => e.MatKhau)
                .IsFixedLength();
        }
    }
}
