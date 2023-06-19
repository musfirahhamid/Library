using Library.DataTbl;

namespace Library.Repository.Interfaces
    {
    public interface IPublication
        {
        Publications AddPublication(Publications publication);
        Publications DeletePublication(int id);
        List<Publications> GetAllPublication();
        Publications GetPublicationbyId(int id);
        Publications UpdatePublication(Publications publication);
        }
    }
