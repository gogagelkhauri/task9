﻿using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Note
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
