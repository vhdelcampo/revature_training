using System.ComponentModel.DataAnnotations;

namespace MovieWorld.Client.Models
{
  public class MovieModel
  {
    [Required(ErrorMessage = "Please fill out a Title")]
    [StringLength(150)]
    public string Title { get; set; }
    [Required(ErrorMessage = "Please fill out a Genre")]
    [DataType(DataType.Text)]
    [GenreAttributes]
    public string Genre { get; set; }
  }
}
