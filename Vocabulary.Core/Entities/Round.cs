using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Round : EntityObject
    {
        public int NumberOfPlayers { get; set; }
        public int RoundWords { get; set; }
        public DateTime StartTime { get; set; }

        public Round()
        {

        }

    }
}
