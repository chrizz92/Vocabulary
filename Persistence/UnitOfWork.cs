using Base.Helper;
using Core.Contracts;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed;

        private readonly ApplicationDbContext _dbContext;
        public IRoundRepository RoundRepository { get; }
        public ITrialRepository TrialRepository { get; }
        public IWordRepository WordRepository { get; }


        public UnitOfWork()
        {
            _dbContext = new ApplicationDbContext();
            RoundRepository = new RoundRepository(_dbContext);
            TrialRepository = new TrialRepository(_dbContext);
            WordRepository = new WordRepository(_dbContext);
        }

        public async Task FillDbAsync()
        {
            await this.DeleteDatabaseAsync();
            await this.MigrateDatabaseAsync();

            List<Word> words;

            string[][] csvData = await MyFile.ReadStringMatrixFromCsvAsync("words.csv",false,'\t');

            words = csvData.Select(line => new Word
            {
                LeftWord = line[0],
                RightWord = line[1]
            }).ToList();

            await _dbContext.Words.AddRangeAsync(words);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            var entities = _dbContext.ChangeTracker.Entries()
               .Where(entity => entity.State == EntityState.Added
                                || entity.State == EntityState.Modified)
               .Select(e => e.Entity);
            foreach (var entity in entities)
            {
                await ValidateEntityAsync(entity);
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task ValidateEntityAsync(object entity)
        {
            //Validation here
        }

        public async Task DeleteDatabaseAsync()
        {
            await _dbContext.Database.EnsureDeletedAsync();
        }

        public async Task MigrateDatabaseAsync()
        {
            try
            {
                await _dbContext.Database.MigrateAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
