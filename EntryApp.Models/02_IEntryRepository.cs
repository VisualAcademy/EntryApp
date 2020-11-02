using Dul.Articles;

namespace EntryApp.Models
{
    public interface IEntryRepository : IRepositoryBase<Entry, long, long>
    {
        // PM> Install-Package Dul
        // Empty
    }
}
