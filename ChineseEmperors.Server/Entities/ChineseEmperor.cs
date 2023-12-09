using System.ComponentModel.DataAnnotations.Schema;

namespace ChineseEmperors.Server.Entities
{
    public class ChineseEmperor
    {
        public int Id { get; set; }
        public required string NickName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EraName { get; set; }
        public string? TempleName { get; set; }
        public string? PosthumousName { get; set; }
        public string? CauseOfDeath { get; set; }
        public int? BirthYear { get; set; }
        public int? DeathYear { get; set; }
        public int? ReignStartYear { get; set; }
        public int? ReignEndYear { get; set; }
        public string Bio { get; set; }


        public int? FatherId { get; set; }
        public ChineseEmperor? Father { get; set; }

        public ICollection<ChineseEmperor>? Sons { get; set; }


        public int? SuccessorId { get; set; }
        public ChineseEmperor? Successor { get; set; }

        public int? PredecessorId { get; set; }
        public ChineseEmperor? Predecessor { get; set; }
    }
}
