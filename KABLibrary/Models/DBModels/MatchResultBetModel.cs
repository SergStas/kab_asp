using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KABLibrary.Models.DBModels
{
    public class MatchResultBetModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Match Match { get; init; }
        [Required]
        public BetEntry HostsWinBE { get; init; }
        [Required]
        public BetEntry DrawBE { get; init; }
        [Required]
        public BetEntry GuestsWinBE { get; init; }
    }
}
