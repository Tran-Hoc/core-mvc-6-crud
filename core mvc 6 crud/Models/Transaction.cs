using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core_mvc_6_crud.Models
{
    public class Transaction
    {

        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName="nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required (ErrorMessage ="Cần nhập thông tin")]
        [MaxLength(12, ErrorMessage = "Tối đa 12 ký tự")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "Cần nhập thông tin")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "Cần nhập thông tin")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT code")]
        [Required(ErrorMessage = "Cần nhập thông tin")]
        [MaxLength(11,ErrorMessage ="Tối đa 11 ký tự")]
        public string SWIFTcode { get; set; }

        [Required(ErrorMessage = "Cần nhập thông tin")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
    }
}
