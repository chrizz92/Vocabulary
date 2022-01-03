using Core.Contracts;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class WordRepository : IWordRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public WordRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Liefert alle Wörter sortiert nach Id
        /// </summary>
        /// <returns></returns>
        public List<Word> GetAll()
        {
            return _dbContext.Words.OrderBy(w => w.Id).ToList();
        }

        /// <summary>
        /// Liefert eine Liste zufälliger Vokabeln (Word).
        /// Achtung! Es wird davon ausgegangen, dass die Id ́s in
        /// der Datenbank lückenlos aufsteigend vergeben wurden!
        /// Die gewünschte Anzahl an Vokabeln wird als Parameter übergeben.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Word> GetRandomWords(int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liefert alle Vokabeln aus einer übergebenen Runde
        /// </summary>
        /// <param name="round_id"></param>
        /// <returns></returns>
        public List<Word> GetWordsByRoundId(int round_id)
        {
            throw new NotImplementedException();
        }
    }
}
