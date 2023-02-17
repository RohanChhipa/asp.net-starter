using System.Text.Json.Serialization;

namespace Infrastructure.Repositories.Reqres.Models;

public class ReqresUser
{
    [JsonPropertyName("id")] public int Id { get; init; }

    [JsonPropertyName("email")] public string Email { get; init; }

    [JsonPropertyName("first_name")] public string FirstName { get; init; }

    [JsonPropertyName("last_name")] public string Lastname { get; init; }

    [JsonPropertyName("avatar")] public string Avatar { get; init; }
}