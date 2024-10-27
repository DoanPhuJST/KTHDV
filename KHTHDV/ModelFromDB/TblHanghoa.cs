using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KHTHDV.ModelFromDB;

[Table("tblHanghoa")]
[Index("Ma", Name = "UQ__tblHangh__3214CCBEB181BD9B", IsUnique = true)]
public partial class TblHanghoa
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("TEN")]
    [StringLength(100)]
    public string Ten { get; set; } = null!;

    [Column("MA")]
    [StringLength(50)]
    public string Ma { get; set; } = null!;

    [Column("DONVI")]
    [StringLength(50)]
    public string? Donvi { get; set; }

    [Column("GIANHAP")]
    public double? Gianhap { get; set; }

    [Column("GIABAN")]
    public double? Giaban { get; set; }

    [Column("NGUOITAO")]
    public Guid? Nguoitao { get; set; }

    [Column("NGAYTAO", TypeName = "datetime")]
    public DateTime? Ngaytao { get; set; }
}
