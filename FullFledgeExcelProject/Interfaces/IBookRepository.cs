using System;

using System.Collections.Generic;
using System.Threading.Tasks;
using FullFledgeExcelProject.Models;
namespace FullFledgeExcelProject.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        // add new note document
        Task AddBook(Book item);
    }
}
