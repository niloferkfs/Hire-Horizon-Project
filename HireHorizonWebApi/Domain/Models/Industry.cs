﻿using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Industry
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}
