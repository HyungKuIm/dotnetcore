using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class CreateGameDto(
    [Required(ErrorMessage ="이름은 필수입니다")][StringLength(50)] string Name,
    int GenreId,
    [Range(0, 1000000)] decimal Price,
    DateOnly ReleaseDate

);
