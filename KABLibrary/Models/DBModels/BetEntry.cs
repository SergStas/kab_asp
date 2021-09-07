using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Models.DBModels
{
    public class BetEntry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Coefficient { get; init; }
        [Required]
        public DateTime UpdateTime { get; set; }
    }
}
