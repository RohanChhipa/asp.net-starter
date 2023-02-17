namespace Domain.Dtos;

public record UserDto
(
    int Id,
    string Email,
    string FirstName,
    string Lastname,
    string Avatar
);