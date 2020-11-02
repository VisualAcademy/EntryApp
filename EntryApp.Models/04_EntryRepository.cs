using Dul.Articles;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntryApp.Models
{
    public class EntryRepository : IEntryRepository
    {
        public Task<Entry> AddAsync(Entry model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entry>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArticleSet<Entry, long>> GetByAsync<TParentIdentifier>(FilterOptions<TParentIdentifier> options)
        {
            throw new NotImplementedException();
        }

        public Task<Entry> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Entry model)
        {
            throw new NotImplementedException();
        }
    }

    public class EntryRepositoryAdoNet
    { 
        // Empty    
    }

    public class EntryRepositoryDapper
    {
        // Empty
    }
}
