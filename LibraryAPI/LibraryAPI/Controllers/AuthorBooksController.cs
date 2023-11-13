using LibraryAPI.Context;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorBooksController : ControllerBase
    {
        private readonly LibraryContext _context;

        public AuthorBooksController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorBook>>> GetAuthorBook()
        {
            return await _context.AuthorBook.ToListAsync();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorBook>> GetAuthorBook(int id)
        {
            var author = await _context.AuthorBook.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthorBook(int id, AuthorBook authorBook)
        {
            if (id != authorBook.ID_AuthorBook)
            {
                return BadRequest();
            }

            _context.Entry(authorBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorBookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Authors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AuthorBook>> PostAuthorBook(AuthorBook author)
        {
            _context.AuthorBook.Add(author);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthorBook", new { id = author.ID_AuthorBook }, author);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorBook>> DeleteAuthorBook(int id)
        {
            var author = await _context.AuthorBook.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            _context.AuthorBook.Remove(author);
            await _context.SaveChangesAsync();

            return author;
        }

        private bool AuthorBookExists(int id)
        {
            return _context.AuthorBook.Any(e => e.ID_AuthorBook == id);
        }
    }
}
