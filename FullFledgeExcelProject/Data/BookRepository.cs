using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

using FullFledgeExcelProject.Interfaces;
using FullFledgeExcelProject.Models;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace FullFledgeExcelProject.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context = null;

        public BookRepository(IOptions<Settings> settings)
        {
            _context = new BookContext(settings);
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            try
            {
                return await _context.Books.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }
        public async Task AddBook(Book item)
        {
            try
            {
                await _context.Books.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                // log or manage the exception
                throw ex;
            }
        }

    }
}
