using System.ComponentModel.DataAnnotations;

namespace SalaryCalculator.Entities
{
    public class SalaryEntity
    {
        public Guid Id { get; set; }
        [Required]
        public uint Brutto { get; set; }
        public double Netto { get; set; } = 0;


    }
}
