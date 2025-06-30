using System.ComponentModel.DataAnnotations;

namespace PatientManagement.Models
{
    public class Patient
    {
        [Key]
        public int Patient_Id { get; set; }

        [Required]
        public string Full_Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Referred_By { get; set; }

        [Required]
        public string Mobile_No1 { get; set; }

        public string? Mobile_No2 { get; set; }

        public string? Aaddhar_No { get; set; }

        public string? Email_ID { get; set; }

        public string Address { get; set; }

        public string? Allergy { get; set; }

        public string? Describe { get; set; }

        public string? Test_Name { get; set; }

        public int? Total_Test { get; set; }

        public double Discount { get; set; }

        public double Total_Amount { get; set; }

        public string? Payment_Status { get; set; }

        public string? Remark { get; set; }
    }
}
