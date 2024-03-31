﻿using System.Text.Json.Serialization;

namespace TaskSQL.Dto.Response;

public record TweetResponseTo(
    [property: JsonPropertyName("id")] long Id,
    [property: JsonPropertyName("creatorId")]
    long CreatorId,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("content")]
    string Content
);