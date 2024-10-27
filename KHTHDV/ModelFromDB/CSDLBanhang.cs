using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KHTHDV.ModelFromDB;

public partial class CSDLBanhang : DbContext
{
    public CSDLBanhang()
    {
    }

    public CSDLBanhang(DbContextOptions<CSDLBanhang> options)
        : base(options)
    {
    }

    public virtual DbSet<TblHanghoa> TblHanghoas { get; set; } = null!;

    
}
