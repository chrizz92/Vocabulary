using Core.Contracts;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class TrialRepository : ITrialRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TrialRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Liefert den Trial mit der übergebenen id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Trial GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Liefert alle aktuellen Spielergebnisse = Trials
        /// einer bestimmten Runde
        /// </summary>
        /// <param name="roundId"></param>
        /// <returns></returns>
        public List<Trial> GetTrialsPerRound(int roundId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speichert einen Spielergebnis-Datensatz eines Spieles
        /// (Ergebnis für eine Runde).
        /// </summary>
        /// <param name="trial"></param>
        /// <returns></returns>
        public bool Insert(Trial trial)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Aktualisert einen Spielergebnis-Datensatz
        /// wenn dieser bereits existiert.
        /// </summary>
        /// <param name="trial"></param>
        /// <returns>true wenn erfolgreich, false wenn Datensatz nicht gefunden</returns>
        public bool Update(Trial trial)
        {
            throw new NotImplementedException();
        }
    }
}
