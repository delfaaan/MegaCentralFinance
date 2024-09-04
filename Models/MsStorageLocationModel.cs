using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCentralFinance.Models
{
	[Table("ms_storage_location")]
	public class MsStorageLocationModel
	{
		[Key]
		[StringLength(10)]
		[Column("location_id")]
		public string? LocationId { get; set; }

		[Required]
		[StringLength(100)]
		[Column("location_name")]
		public string? LocationName { get; set; }
	}
}