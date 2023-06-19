using Library.DataTbl;
using Library.Repository.Interfaces;

namespace Library.Repository.Repositories
    {
    public class PublicationRepository : IPublication
        {
        private readonly LibraryContext _context;

        public PublicationRepository(LibraryContext context)
            {
            _context = context;
            }

        public List<Publications> GetAllPublication()
            {
            return _context.publications.Where(row => row.Status == true).ToList();
            }

        public Publications GetPublicationbyId(int id)
            {
            throw new NotImplementedException();
            }

        public Publications AddPublication(Publications publication)
            {
            publication.Status = true;
            _context.publications.Add(publication);
            _context.SaveChanges();
            return publication;
            }

        public Publications UpdatePublication(Publications publication)
            {
            publication.Status = true;
            _context.publications.Update(publication);
            _context.SaveChanges();
            return publication;
            }
        public Publications DeletePublication(int id)
            {
             var publication = _context.publications.Find(id);
           
               if(publication != null)
                {
                publication.Status = false;
                _context.publications.Update(publication);
                _context.SaveChanges();
                }
            return publication;

            }
        }
    }
