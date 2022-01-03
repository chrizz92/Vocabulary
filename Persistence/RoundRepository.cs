using Core.Contracts;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class RoundRepository : IRoundRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RoundRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Erstellt einen neue Runde und setzt die Startzeit auf die aktuelle Zeit
        /// Dann werden 10 zufällige Vokabeln gewählt (id ́s zufällig wählen) und
        /// erstellt die entsprechenden Einträge in der RoundWords-Table
        /// </summary>
        public void GenerateNewRound()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liefert die aktuelle Runde (ist immer die zuletzt erstellt Runde)
        /// </summary>
        /// <returns></returns>
        public Round GetActualRound()
        {
            throw new NotImplementedException();
        }
    }
}
