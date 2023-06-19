using System.ComponentModel.DataAnnotations;

namespace Library.DataTbl
    {
    public class Common
        {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        }
    }
