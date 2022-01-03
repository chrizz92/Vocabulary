using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        public IRoundRepository RoundRepository { get;}
        public ITrialRepository TrialRepository { get; }
        public IWordRepository WordRepository { get; }

        Task FillDbAsync();
    }
}
