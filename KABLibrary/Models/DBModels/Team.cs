using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Models.DBModels
{
    public class Team
    {
        [Key]
        public int Id { get; init; }
        [Required]
        [MaxLength(50)]
        public string Name { get; init; }
    }
}
