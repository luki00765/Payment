using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
	public class PaymentDetail
	{
		[Key]
		public int PaymentDetailId { get; set; }

		[Column("nvarchar(100)")]
		public string CardOwnerName { get; set; }

		[Column("nvarchar(16)")]
		public string CardNumber { get; set; }

		[Column("nvarchar(5)")]
		public string ExppirationDate { get; set; }

		[Column("nvarchar(3)")]
		public string SecurityCode { get; set; }
	}
}
