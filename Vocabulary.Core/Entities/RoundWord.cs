using Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RoundWord : EntityObject
    {
        public int CorrectAnswers { get; set; }
        public int GiveUps { get; set; }
        public int WrongAnswers { get; set; }
        [ForeignKey("WordId")]
        public Word Word { get; set; }
        public int WordId { get; set; }
        public Round Round { get; set; }
    }
}
