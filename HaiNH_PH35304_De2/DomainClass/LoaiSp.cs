using System;
using System.Collections.Generic;

namespace De2.DomainClass;

public partial class LoaiSp
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
