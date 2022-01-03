using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IWordRepository
    {
        public List<Word> GetAll();
        public List<Word> GetWordsByRoundId(int round_id);
        public List<Word> GetRandomWords(int count);
    }
}
