namespace Mission11_Fails.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
