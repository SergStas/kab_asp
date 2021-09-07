using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Models.DBModels
{
    public class Match
    {
        [Key]
        public int Id { get; init; }
        [Required]
        public Team Hosts { get; init; }
        [Required]
        public Team Guests { get; init; }
        [Required]
        public DateTime MatchDate { get; init; }
    }
}
