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
    public class Trial : EntityObject
    {
        public int CorrectWords { get; set; }
        public int GiveUps { get; set; }
        public string IPAddress { get; set; }
        public int Mistakes { get; set; }
        public int Points { get; set; }
        public DateTime SubmittedAt { get; set; }
        public double Time { get; set; }
        public string UserName { get; set; }
        [ForeignKey("RoundId")]
        public Round Round { get; set; }
        public int RoundId { get; set; }
    }
}
