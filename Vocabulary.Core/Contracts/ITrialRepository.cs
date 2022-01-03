using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface ITrialRepository
    {
        public Trial GetById(int id);
        public bool Insert(Trial trial);
        public bool Update(Trial trial);
        public List<Trial> GetTrialsPerRound(int roundId);

    }
}
