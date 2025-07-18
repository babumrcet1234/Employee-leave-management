using System;
using System.Collections.Generic;

namespace ELM.API.Models;

public partial class RefreshToken
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime Expires { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Revoked { get; set; }

    public virtual User Employee { get; set; } = null!;
}
