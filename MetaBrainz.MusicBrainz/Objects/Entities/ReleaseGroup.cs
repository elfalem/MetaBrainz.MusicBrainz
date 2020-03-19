﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

using JetBrains.Annotations;

using MetaBrainz.MusicBrainz.Interfaces.Entities;
using MetaBrainz.MusicBrainz.Interfaces.Searches;

namespace MetaBrainz.MusicBrainz.Objects.Entities {

  [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
  internal sealed class ReleaseGroup : Entity, IFoundReleaseGroup {

    public override EntityType EntityType => EntityType.ReleaseGroup;

    [JsonPropertyName("aliases")]
    public IReadOnlyList<IAlias>? Aliases { get; set; }

    [JsonPropertyName("annotation")]
    public string? Annotation { get; set; }

    [JsonPropertyName("artist-credit")]
    public IReadOnlyList<INameCredit>? ArtistCredit { get; set; }

    [JsonPropertyName("disambiguation")]
    public string? Disambiguation { get; set; }

    [JsonPropertyName("first-release-date")]
    public PartialDate? FirstReleaseDate { get; set; }

    [JsonPropertyName("genres")]
    public IReadOnlyList<ITag>? Genres { get; set; }

    [JsonPropertyName("primary-type")]
    public string? PrimaryType { get; set; }

    [JsonPropertyName("primary-type-id")]
    public Guid? PrimaryTypeId { get; set; }

    [JsonPropertyName("rating")]
    public IRating? Rating { get; set; }

    [JsonPropertyName("relations")]
    public IReadOnlyList<IRelationship>? Relationships { get; set; }

    [JsonPropertyName("releases")]
    public IReadOnlyList<IRelease>? Releases { get; set; }

    [JsonPropertyName("secondary-types")]
    public IReadOnlyList<string>? SecondaryTypes { get; set; }

    [JsonPropertyName("secondary-type-ids")]
    public IReadOnlyList<Guid>? SecondaryTypeIds { get; set; }

    [JsonPropertyName("tags")]
    public IReadOnlyList<ITag>? Tags { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("user-genres")]
    public IReadOnlyList<IUserTag>? UserGenres { get; set; }

    [JsonPropertyName("user-rating")]
    public IUserRating? UserRating { get; set; }

    [JsonPropertyName("user-tags")]
    public IReadOnlyList<IUserTag>? UserTags { get; set; }

    public override string ToString() {
      var text = string.Empty;
      if (this.SearchScore.HasValue)
        text += $"[Score: {this.SearchScore.Value}] ";
      if (this.ArtistCredit != null) {
        foreach (var nc in this.ArtistCredit)
          text += nc.ToString();
        text += " / ";
      }
      text += this.Title;
      if (!string.IsNullOrEmpty(this.Disambiguation))
        text += $" ({this.Disambiguation})";
      if (!string.IsNullOrEmpty(this.PrimaryType))
        text += $" ({this.PrimaryType})";
      return text;
    }

  }

}
