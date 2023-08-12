using System.ComponentModel.DataAnnotations;

namespace SalaryCalculator.Entities
{
    public class TypeOfContractEntity
    {
        public int Id { get; set; }
        [Required, StringLength(40)]
        public string FullName { get; set; }
        [StringLength(10)]
        public string Shortcut { get; set; }
    }
}
