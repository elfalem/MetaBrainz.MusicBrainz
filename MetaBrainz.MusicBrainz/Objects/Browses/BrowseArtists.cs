﻿using System;
using System.Collections.Generic;

using MetaBrainz.MusicBrainz.Interfaces.Entities;

namespace MetaBrainz.MusicBrainz.Objects.Browses;

internal sealed class BrowseArtists : BrowseResults<IArtist> {

  public BrowseArtists(Query query, IReadOnlyDictionary<string, string> options, int? limit,
                       int? offset) : base(query, "artist", null, options, limit, offset) {
  }

  public override IReadOnlyList<IArtist> Results => this.CurrentResult?.Artists ?? Array.Empty<IArtist>();

}
