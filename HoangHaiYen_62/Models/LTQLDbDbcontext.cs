using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HoangHaiYen_62.Models
{
    public partial class LTQLDbDbcontext : DbContext
    {
        public LTQLDbDbcontext()
            : base("name=LTQLDbDbcontext")
        {
        }
public virtual DbSet<NhaCungCap> Nhacungcaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
