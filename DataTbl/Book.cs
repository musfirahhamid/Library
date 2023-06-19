namespace Library.DataTbl
    {
    public class Book:Common
        {
        public int BookQuantity { get; set; }
        
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public DateTime BookDateAdded { get; set; }
        public string BookCondition { get; set; }
        public int AvailableBooks { get; set; }
        }
    }
