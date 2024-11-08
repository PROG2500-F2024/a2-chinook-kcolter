﻿using System;
using System.Collections.Generic;

namespace PROG2500_A2_Chinook.Models.Generated;

public partial class Playlist
{
    public int PlaylistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
