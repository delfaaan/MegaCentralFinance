using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MegaCentralFinance.Models.Dto
{
	public class LoginDto
	{
		[Required]
		[JsonPropertyName("user_name")]
		public string? UserName { get; set; }
		
		[Required]
		[JsonPropertyName("password")]
		public string? Password { get; set; }
	}
}