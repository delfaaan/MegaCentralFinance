using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaCentralFinance.Models
{
	[Table("tr_bpkb")]
	public class TrBpkbModel
	{
		[Key]
		[StringLength(100)]
		[Column("agreement_number")]
		public string? AgreementNumber { get; set; }

		[Required]
		[StringLength(100)]
		[Column("bpkb_no")]
		public string? BpkbNo { get; set; }

		[Required]
		[StringLength(10)]
		[Column("branch_id")]
		public string? BranchId { get; set; }

		[Required]
		[Column("bpkb_date")]
		public DateTime BpkbDate { get; set; }

		[Required]
		[StringLength(100)]
		[Column("faktur_no")]
		public string? FakturNo { get; set; }

		[Required]
		[Column("faktur_date")]
		public DateTime FakturDate { get; set; }

		[Required]
		[StringLength(10)]
		[Column("location_id")]
		public string? LocationId { get; set; }

		[Required]
		[StringLength(20)]
		[Column("police_no")]
		public string? PoliceNo { get; set; }

		[Required]
		[Column("bpkb_date_in")]
		public DateTime BpkbDateIn { get; set; }

		[Required]
		[StringLength(20)]
		[Column("created_by")]
		public string? CreatedBy { get; set; }

		[Required]
		[Column("created_on")]
		public DateTime CreatedOn { get; set; }

		[Required]
		[StringLength(20)]
		[Column("last_updated_by")]
		public string? LastUpdatedBy { get; set; }

		[Required]
		[Column("last_updated_on")]
		public DateTime LastUpdatedOn { get; set; }
	}
}