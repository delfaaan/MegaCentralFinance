using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCentralFinance.Models
{
	[Table("ms_user")]
	public class MsUserModel
	{
		[Key]
		[Column("user_id")]
		public long UserId { get; set; }

		[Required]
		[StringLength(20)]
		[Column("user_name")]
		public string? UserName { get; set; }

		[Required]
		[StringLength(50)]
		[Column("password")]
		public string? Password { get; set; }

		[Column("is_active")]
		public bool IsActive { get; set; }
	}
}