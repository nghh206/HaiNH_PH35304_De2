using System;
using System.Collections.Generic;

namespace De2.DomainClass;

public partial class LoaiXm
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<XeMay> XeMays { get; set; } = new List<XeMay>();
}
