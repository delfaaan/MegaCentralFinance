using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MegaCentralFinance.Models.Dto
{
	public class CreateBpkbDto
	{
		[Required]
		[StringLength(100)]
		[JsonPropertyName("agreement_number")]
		public string? AgreementNumber { get; set; }

		[Required]
		[StringLength(100)]
		[JsonPropertyName("bpkb_no")]
		public string? BpkbNo { get; set; }
		
		[Required]
		[StringLength(10)]
		[JsonPropertyName("branch_id")]
		public string? BranchId { get; set; }

		[Required]
		[JsonPropertyName("bpkb_date")]
		public DateTime BpkbDate { get; set; }

		[Required]
		[StringLength(100)]
		[JsonPropertyName("faktur_no")]
		public string? FakturNo { get; set; }

		[Required]
		[JsonPropertyName("faktur_date")]
		public DateTime FakturDate { get; set; }

		[Required]
		[StringLength(10)]
		[JsonPropertyName("location_id")]
		public string? LocationId { get; set; }

		[Required]
		[StringLength(20)]
		[JsonPropertyName("police_no")]
		public string? PoliceNo { get; set; }

		[Required]
		[JsonPropertyName("bpkb_date_in")]
		public DateTime BpkbDateIn { get; set; }
	}
}