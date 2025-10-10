using BusinessAL.DbContext;
using BusinessAL.Repositories.BaseRepositories;
using DataAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.Repositories
{

    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        private readonly RepositoryContext _context;
        public DocumentRepository(RepositoryContext _context)
            : base(_context)
        {
            this._context = _context;
        }
        public Document GetById(int id)
        {
            var list =  _context.Document.ToList();
            var obj = list.Where(i => i.DocumentId == id).FirstOrDefault();
            return _context.Document.Where(i => i.DocumentId == id).FirstOrDefault(); ;
        }
    }

    public interface IDocumentRepository : IBaseRepository<Document>
    {

    }
}
