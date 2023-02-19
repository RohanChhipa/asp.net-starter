using System.Text.Json.Serialization;

namespace Infrastructure.Reqres.Models;

public class ReqresResponse
{
    [JsonPropertyName("page")] public int Page { get; init; }

    [JsonPropertyName("per_page")] public int PerPage { get; init; }

    [JsonPropertyName("total")] public int Total { get; init; }

    [JsonPropertyName("total_pages")] public int TotalPages { get; init; }

    [JsonPropertyName("data")] public IEnumerable<ReqresUser> Data { get; init; }
}