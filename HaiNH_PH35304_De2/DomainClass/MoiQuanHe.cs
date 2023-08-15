using System;
using System.Collections.Generic;

namespace De2.DomainClass;

public partial class MoiQuanHe
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();
}
